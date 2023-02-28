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
        PaintModel Model;

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
            Model.ObjBmp = new Bitmap(Canvas.Width, Canvas.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Canvas.Image = Model.ObjBmp;
            Model.ObjGrp = Graphics.FromImage(Canvas.Image);
            Model.ObjGrp.Clear(Color.White);

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
                Model.ActiveButton.BackColor = Color.Gainsboro;
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
            Model.TempPoint = Point.Empty;
        }



        #region MouseEvent
        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            Model.IsDraw = true;
            Model.TempPoint = e.Location;
        }
        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (Model.IsDraw)
            {
                Model.IsDraw = false;

                if (Model.DrawMode == PaintModel.Mode.Bucket)
                {
                    Bucket.FillArea(Model.ObjBmp, e.Location, Model.DrawColor);

                    Canvas.Refresh();
                }
            }
        }
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (!Model.IsDraw)
            {
                return;
            }

            switch (Model.DrawMode)
            {
                case PaintModel.Mode.Pen:
                    //線を描画
                    Line.LineDrawing(Model.TempPoint, e.Location, Model.ObjGrp, Model.DrawColor, Model.PenWidth);
                    break;
                case PaintModel.Mode.Eraser:
                    //消しゴム
                    Eraser.LineErasing(Model.TempPoint, e.Location, Model.ObjGrp, Model.PenWidth);
                    break;
                case PaintModel.Mode.Bucket:
                    //塗りつぶし
                    //ここでは行わない
                    break;
                case PaintModel.Mode.Rectangle:
                    //矩形描画
                    break;
                case PaintModel.Mode.Circle:
                    //円描画
                    break;
                case PaintModel.Mode.Select:
                    //範囲指定
                    break;
                default:
                    break;
            }

            Canvas.Refresh();
            Model.TempPoint = e.Location;
        }
        #endregion

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
            if(int.TryParse(CmbPenWidth.Text, out int width))
            {
                Model.PenWidth = width;
            }
        }

        private void SelectColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            DialogResult dialogResult = colorDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                Model.DrawColor = colorDialog.Color;
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Model.ObjGrp.Clear(Color.White);

            Canvas.Refresh();
        }

        private void Canvas_ClientSizeChanged(object sender, EventArgs e)
        {
            //Model.ObjBmp = new Bitmap(Canvas.Width, Canvas.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
            //Canvas.Image = Model.ObjBmp;
            //Model.ObjGrp = Graphics.FromImage(Canvas.Image);
        }
    }
}
