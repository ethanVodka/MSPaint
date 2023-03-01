using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices.WindowsRuntime;
using System.ComponentModel;

namespace MSPaint.Models
{
    public class PaintModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public enum Mode
        {
            Pen,
            Eraser,
            Bucket,
            Rectangle,
            Circle,
            Line
        }

        /// <summary>
        /// シングルトンインスタンス
        /// </summary>
        private static PaintModel InstancePaintModel = null;

        private PaintModel()
        {
            //
            // コンストラクター
            //
        }

        public static PaintModel GetInstance()
        {
            InstancePaintModel = new PaintModel();

            return InstancePaintModel;
        }

        #region Field
        //描画色
        private Color drawingColor = Color.Black;
        //ペン幅
        private int penWidth = 1;
        //アクティブタン
        private Button activeButton = null;
        //アクティブモード
        private Mode drawMode = 0;
        //描画可能フラグ
        private bool isDraw = false;
        //フォントファミリー
        private FontFamily drawFontFamily = new FontFamily("MS UI Gothic");
        //フォントスタイル
        private FontStyle drawFontStyle = FontStyle.Regular;
        //フォントサイズ
        private int drawFontSize = 9;
        #endregion

        #region Property
        public Color DrawColor
        {
            get { return drawingColor; }
            set 
            { 
                drawingColor = value;
                OnPropertyChanged(nameof(DrawColor));
            }
        }
        public int PenWidth
        {
            get { return penWidth; }
            set { penWidth = value; }
        }
        public Button ActiveButton
        {
            get { return activeButton; }
            set { activeButton = value; }
        }
        public Mode DrawMode
        {
            get { return drawMode; }
            set { drawMode = value; }
        }
        public bool IsDraw
        {
            get { return isDraw; }
            set { isDraw = value; }
        }
        public FontFamily DrawFontFamily
        {
            get { return drawFontFamily; }
            set
            {
                drawFontFamily = value;
                OnPropertyChanged(nameof(DrawFontFamily));
            }
        }
        public FontStyle DrawFontStyle
        {
            get { return drawFontStyle; }
            set
            {
                drawFontStyle = value;
                OnPropertyChanged(nameof(DrawFontStyle));
            }
        }
        public int DrawFontSize
        {
            get { return drawFontSize; }
            set
            {
                drawFontSize = value;
                OnPropertyChanged(nameof(DrawFontSize));
            }
        }
        #endregion
    }
}
