using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;

namespace MSPaint
{
    //線を描くクラス
    public class Line
    {
        #region Methods
        public static void LineDrawing(Point prevPoint ,Point curentPoint, Graphics objGrp, Color color, int penWidth)
        {
            using (Pen pen = new Pen(color, penWidth))
            {
                Brush brush = new SolidBrush(color);
                //線を描く
                objGrp.DrawLine(pen, prevPoint, curentPoint);
                //線と線の空白をまるで埋める
                objGrp.FillEllipse(brush, prevPoint.X - penWidth / 2, prevPoint.Y - penWidth / 2, penWidth, penWidth);
            }
        }
        #endregion
    }
}
