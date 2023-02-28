using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPaint
{
    public class Eraser
    {
        #region Methods
        public static void LineErasing(Point prevPoint, Point curentPoint, Graphics objGrp, int penWidth)
        {
            using (Pen pen = new Pen(Color.White, penWidth))
            {
                //線を描く
                objGrp.DrawLine(pen, prevPoint, curentPoint);
                //線と線の空白をまるで埋める
                objGrp.FillEllipse(Brushes.White, prevPoint.X - penWidth / 2, prevPoint.Y - penWidth / 2, penWidth, penWidth);
            }
        }
        #endregion
    }
}
