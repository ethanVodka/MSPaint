using MSPaint.DrawMethods;
using MSPaint.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSPaint
{
    public partial class MainForm : Form
    {
        //C++ネイティブコードのインポート
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        #region Feiled
        //モデルインスタンス
        private PaintModel Model { get; set; }
        private Bitmap ObjBmp { get; set; }
        private Graphics ObjGrp { get; set; }
        private Point StartPoint { get; set; } = Point.Empty;
        private Point PrevPoint { get; set; } = Point.Empty;
        private Point CurrentPoint { get; set; } = Point.Empty;
        private Point EndPoint { get; set; } = Point.Empty;
        #endregion

        //コンストラクター
        public MainForm()
        {
            InitializeComponent();

            Model = PaintModel.GetInstance();

            //Modelとデータバインディング
            LabelFontFamily.DataBindings.Add("Text", Model, nameof(Model.DrawFontFamily), true, DataSourceUpdateMode.OnPropertyChanged);
            LabelFontStyle.DataBindings.Add("Text", Model, nameof(Model.DrawFontStyle), true, DataSourceUpdateMode.OnPropertyChanged);
            LabelFontSize.DataBindings.Add("Text", Model, nameof(Model.DrawFontSize), true, DataSourceUpdateMode.OnPropertyChanged);
            SelectColor.DataBindings.Add("BackColor", Model, nameof(Model.DrawColor), true, DataSourceUpdateMode.OnPropertyChanged);

            //Bitmap初期化
            ObjBmp = new Bitmap(Canvas.Width, Canvas.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
            ObjGrp = Graphics.FromImage(ObjBmp);
            ObjGrp.Clear(Color.White);

            Canvas.Image = ObjBmp;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ActivateButton(BtnPen_0);
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void PanelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
        private void ModeButton_MouseClick(object sender, MouseEventArgs e)
        {
            ActivateButton((Button)sender);
        }
        private void ActivateButton(Button btn)
        {
            if (Model.ActiveButton != null)
            {
                Model.ActiveButton.BackColor = Color.DarkGray;
            }

            //ボタン名からモード設定
            string[] splitName = btn.Name.ToString().Split('_');
            if (int.TryParse(splitName[1], out int index))
            {
                Model.DrawMode = (Models.PaintModel.Mode)index;
            }
            else
            {
                throw new Exception("faile to selet drawing mode");
            }

            Model.ActiveButton = btn;
            btn.BackColor = Color.Red;
        }
        private void BtnSelectFont_Click(object sender, EventArgs e)
        {
            FontDialog drawaingFontDialog = new FontDialog
            {
                ShowColor = true
            };

            DialogResult dialogResult = drawaingFontDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                Model.DrawFontFamily = drawaingFontDialog.Font.FontFamily;
                Model.DrawFontStyle = drawaingFontDialog.Font.Style;
                Model.DrawFontSize = (int)drawaingFontDialog.Font.Size;
                Model.DrawColor = drawaingFontDialog.Color;
            }
        }
        private void SelectPenWidth_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectRegular.Checked)
            {
                Model.PenWidth = 1;
            }
            else
            {
                Model.PenWidth = 3;
            }
        }
        private void CmbPenWidth_SelectedValueChanged(object sender, EventArgs e)
        {
            if (int.TryParse(CmbPenWidth.Text, out int width))
            {
                Model.PenWidth = width;
            }
        }
        private void SelectColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                DialogResult dialogResult = colorDialog.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    Model.DrawColor = colorDialog.Color;
                }
            }
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            ObjGrp.Clear(Color.White);

            Canvas.Refresh();
        }
        private void Canvas_ClientSizeChanged(object sender, EventArgs e)
        {
            //Model.ObjBmp = new Bitmap(Canvas.Width, Canvas.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
            //Canvas.Image = Model.ObjBmp;
            //Model.ObjGrp = Graphics.FromImage(Canvas.Image);
        }
        private void BtnSelectColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                DialogResult dialogResult = colorDialog.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    Model.DrawColor = colorDialog.Color;
                }
            }
        }


        #region MouseEvent
        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            Model.IsDraw = true;

            //連続描画Prev
            PrevPoint = e.Location;
            //矩形描画Start
            StartPoint = e.Location;
        }
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (!Model.IsDraw)
            {
                return;
            }
            //途中経過描画Current
            CurrentPoint = e.Location;

            switch (Model.DrawMode)
            {
                case PaintModel.Mode.Pen:
                    using (Brush brush = new SolidBrush(Model.DrawColor))
                    using (Pen pen = new Pen(Model.DrawColor, Model.PenWidth))
                    {
                        //線を描く
                        ObjGrp.DrawLine(pen, PrevPoint, CurrentPoint);
                        //線と線の空白をまるで埋める
                        ObjGrp.FillEllipse(brush, PrevPoint.X - Model.PenWidth / 2, PrevPoint.Y - Model.PenWidth / 2, Model.PenWidth, Model.PenWidth);
                        //座標更新
                        PrevPoint = CurrentPoint;
                    }
                    break;

                case PaintModel.Mode.Eraser:
                    using (Pen pen = new Pen(Color.White, Model.PenWidth))
                    {
                        //線を描く
                        ObjGrp.DrawLine(pen, PrevPoint, CurrentPoint);
                        //座標更新
                        PrevPoint = CurrentPoint;
                    }
                    break;

                default:
                    break;
            }

            Canvas.Refresh();
        }
        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (Model.IsDraw)
            {
                Model.IsDraw = false;
            }

            EndPoint = e.Location;

            switch (Model.DrawMode)
            {
                case PaintModel.Mode.Bucket:
                    DBucket.FillArea(ObjBmp, e.Location, Model.DrawColor);
                    break;

                case PaintModel.Mode.Rectangle:
                    using (Pen pen = new Pen(Model.DrawColor, Model.PenWidth))
                    {
                        ObjGrp.DrawRectangle(pen, GetRect(StartPoint, EndPoint));
                    }
                    break;

                case PaintModel.Mode.Circle:
                    using (Pen pen = new Pen(Model.DrawColor, Model.PenWidth))
                    {
                        ObjGrp.DrawEllipse(pen, GetRect(StartPoint, EndPoint));
                    }

                    break;

                case PaintModel.Mode.Line:
                    using (Brush brush = new SolidBrush(Model.DrawColor))
                    using (Pen pen = new Pen(Model.DrawColor, Model.PenWidth))
                    {
                        ObjGrp.DrawLine(pen, StartPoint, EndPoint);
                        ObjGrp.FillEllipse(brush, StartPoint.X - Model.PenWidth / 2, StartPoint.Y - Model.PenWidth / 2, Model.PenWidth, Model.PenWidth);
                        ObjGrp.FillEllipse(brush, EndPoint.X - Model.PenWidth / 2, EndPoint.Y - Model.PenWidth / 2, Model.PenWidth, Model.PenWidth);
                    }
                    break;
            }

            Canvas.Refresh();
        }
        #endregion

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (Model.IsDraw)
            {
                switch (Model.DrawMode)
                {
                    case PaintModel.Mode.Rectangle:
                        using (Pen pen = new Pen(Model.DrawColor, Model.PenWidth))
                        {
                            g.DrawRectangle(pen, GetRect(StartPoint, CurrentPoint));
                        }
                        break;

                    case PaintModel.Mode.Circle:
                        using (Pen pen = new Pen(Model.DrawColor, Model.PenWidth))
                        {
                            g.DrawEllipse(pen, GetRect(StartPoint, CurrentPoint));
                        }
                        break;

                    case PaintModel.Mode.Line:
                        using (Brush brush = new SolidBrush(Model.DrawColor))
                        using (Pen pen = new Pen(Model.DrawColor, Model.PenWidth))
                        {
                            g.DrawLine(pen, StartPoint, CurrentPoint);
                            g.FillEllipse(brush, StartPoint.X - Model.PenWidth / 2, StartPoint.Y - Model.PenWidth / 2, Model.PenWidth, Model.PenWidth);
                            g.FillEllipse(brush, CurrentPoint.X - Model.PenWidth / 2, CurrentPoint.Y - Model.PenWidth / 2, Model.PenWidth, Model.PenWidth);
                        }
                        break;
                }
            }
        }

        private Rectangle GetRect(Point sPoint, Point epoint)
        {
            Rectangle rect = new Rectangle
            {
                X = Math.Min(sPoint.X, epoint.X),

                Y = Math.Min(sPoint.Y, epoint.Y),

                Width = Math.Abs(sPoint.X - epoint.X),

                Height = Math.Abs(sPoint.Y - epoint.Y)
            };

            return rect;
        }
    }
}
