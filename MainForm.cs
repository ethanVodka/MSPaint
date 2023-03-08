using MSPaint.DrawMethods;
using MSPaint.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
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

        #region Property
        //モデルインスタンス
        private PaintModel Model { get; set; }
        private Bitmap ObjBmp { get; set; } = null;
        private Graphics ObjGrp { get; set; } = null;
        #endregion

        //コンストラクター
        public MainForm()
        {
            InitializeComponent();

            Model = PaintModel.GetInstance();

            //Modelとデータバインディング
            SelectedColor.DataBindings.Add("ForeColor", Model, nameof(Model.DrawColor), true, DataSourceUpdateMode.OnPropertyChanged);

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
            Application.Exit();
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
                Model.ActiveButton.BackColor = Color.White;
            }

            //ボタン名からモード設定
            string[] splitName = btn.Name.ToString().Split('_');
            if (int.TryParse(splitName[1], out int index))
            {
                Model.DrawMode = (PaintModel.Mode)index;
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
            Model.PrevPoint = e.Location;
            //矩形描画Start
            Model.StartPoint = e.Location;
        }
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (!Model.IsDraw)
            {
                return;
            }
            //途中経過描画Current
            Model.CurrentPoint = e.Location;

            switch (Model.DrawMode)
            {
                case PaintModel.Mode.Pen:
                    using (Brush brush = new SolidBrush(Model.DrawColor))
                    using (Pen pen = new Pen(Model.DrawColor, Model.PenWidth))
                    {
                        //線を描く
                        ObjGrp.DrawLine(pen, Model.PrevPoint, Model.CurrentPoint);
                        //線と線の空白をまるで埋める
                        ObjGrp.FillEllipse(brush, Model.PrevPoint.X - Model.PenWidth / 2, Model.PrevPoint.Y - Model.PenWidth / 2, Model.PenWidth, Model.PenWidth);
                        //座標更新
                        Model.PrevPoint = Model.CurrentPoint;
                    }
                    break;

                case PaintModel.Mode.Eraser:
                    using (Brush brush = new SolidBrush(Color.White))
                    using (Pen pen = new Pen(Color.White, Model.PenWidth))
                    {
                        ObjGrp.DrawLine(pen, Model.PrevPoint, Model.CurrentPoint);
                        ObjGrp.FillEllipse(brush, Model.PrevPoint.X - Model.PenWidth / 2, Model.PrevPoint.Y - Model.PenWidth / 2, Model.PenWidth, Model.PenWidth);
                        //座標更新
                        Model.PrevPoint = Model.CurrentPoint;
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

            Model.EndPoint = e.Location;

            switch (Model.DrawMode)
            {
                case PaintModel.Mode.Bucket:
                    DBucket.FillArea(ObjBmp, e.Location, Model.DrawColor);
                    break;

                case PaintModel.Mode.Rectangle:
                    using (Pen pen = new Pen(Model.DrawColor, Model.PenWidth))
                    {
                        ObjGrp.DrawRectangle(pen, GetRect(Model.StartPoint, Model.EndPoint));
                    }
                    break;

                case PaintModel.Mode.Circle:
                    using (Pen pen = new Pen(Model.DrawColor, Model.PenWidth))
                    {
                        ObjGrp.DrawEllipse(pen, GetRect(Model.StartPoint, Model.EndPoint));
                    }

                    break;

                case PaintModel.Mode.Line:
                    using (Brush brush = new SolidBrush(Model.DrawColor))
                    using (Pen pen = new Pen(Model.DrawColor, Model.PenWidth))
                    {
                        ObjGrp.DrawLine(pen, Model.StartPoint, Model.EndPoint);
                        ObjGrp.FillEllipse(brush, Model.StartPoint.X - Model.PenWidth / 2, Model.StartPoint.Y - Model.PenWidth / 2, Model.PenWidth, Model.PenWidth);
                        ObjGrp.FillEllipse(brush, Model.EndPoint.X - Model.PenWidth / 2, Model.EndPoint.Y - Model.PenWidth / 2, Model.PenWidth, Model.PenWidth);
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
                            g.DrawRectangle(pen, GetRect(Model.StartPoint, Model.CurrentPoint));
                        }
                        break;

                    case PaintModel.Mode.Circle:
                        using (Pen pen = new Pen(Model.DrawColor, Model.PenWidth))
                        {
                            g.DrawEllipse(pen, GetRect(Model.StartPoint, Model.CurrentPoint));
                        }
                        break;

                    case PaintModel.Mode.Line:
                        using (Brush brush = new SolidBrush(Model.DrawColor))
                        using (Pen pen = new Pen(Model.DrawColor, Model.PenWidth))
                        {
                            g.DrawLine(pen, Model.StartPoint, Model.CurrentPoint);
                            g.FillEllipse(brush, Model.StartPoint.X - Model.PenWidth / 2, Model.StartPoint.Y - Model.PenWidth / 2, Model.PenWidth, Model.PenWidth);
                            g.FillEllipse(brush, Model.CurrentPoint.X - Model.PenWidth / 2, Model.CurrentPoint.Y - Model.PenWidth / 2, Model.PenWidth, Model.PenWidth);
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

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Filter = "イメージファイル(*.png;*.PNG;*.Png)|*.png;*.PNG;*.Png|イメージファイル(*.jpeg;*.Jpeg;*.Jpg)|*.jpeg;*.Jpeg;*.Jpg|すべてのファイル(*.*)|*.*",
                Title = "開く画像を選択してください",
                RestoreDirectory = true,
                CheckFileExists = true
            };

            DialogResult = openFileDialog.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                Canvas.Image = Image.FromFile(openFileDialog.FileName);
                ObjBmp = (Bitmap)Canvas.Image;
                ObjGrp = Graphics.FromImage(ObjBmp);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Save",
                Filter = "イメージファイル(*.jpg)|*.jpg|(*.*)|*.*",
                RestoreDirectory = true,
            };

            DialogResult = saveFileDialog.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                Bitmap bmp = ObjBmp.Clone(new Rectangle(0, 0, Canvas.Width, Canvas.Height), ObjBmp.PixelFormat);
                bmp.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
            }
        }

        private void ColorPalette_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox palette = sender as PictureBox;
            Model.DrawColor = palette.BackColor;
        }

        private void Canvas_SizeChanged(object sender, EventArgs e)
        {
            if (ObjBmp != null)
            {
                ObjBmp = new Bitmap(Canvas.Width, Canvas.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
                ObjGrp = Graphics.FromImage(ObjBmp);
                ObjGrp.Clear(Color.White);
                ObjGrp.DrawImage(Canvas.Image, new Point(0, 0));

                Canvas.Image = ObjBmp;
            }
        }
    }
}
