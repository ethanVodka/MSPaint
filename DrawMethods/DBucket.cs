using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace MSPaint.DrawMethods
{
    public class DBucket
    {
        #region Methods
        public static void FillArea(Bitmap bitmap, Point location, Color color)
        {
            //ビットマップロック
            BitmapData data = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);

            int[] bits = new int[data.Stride / 4 * data.Height];
            Marshal.Copy(data.Scan0, bits, 0, bits.Length);

            LinkedList<Point> check = new LinkedList<Point>();
            //塗りつぶすのピクセルの色
            int floodTo = color.ToArgb();
            //塗りつぶす元のピクセルの色
            int floodFrom = bits[location.X + (location.Y * data.Stride / 4)];
            bits[location.X + (location.Y * data.Stride / 4)] = floodTo;

            if (floodFrom != floodTo)
            {
                check.AddLast(location);
                while (check.Count > 0)
                {
                    Point cur = check.First.Value;
                    check.RemoveFirst();

                    //クリック座標のピクセルと隣接するピクセル比較
                    //クリック座標のピクセルの色と異なるピクセルに当たるまで探索繰り返す
                    //該当ピクセルの色を変更
                    foreach (Point off in new Point[] { new Point(0, -1), new Point(0, 1), new Point(-1, 0), new Point(1, 0) })
                    {
                        Point next = new Point(cur.X + off.X, cur.Y + off.Y);
                        if (next.X >= 0 && next.Y >= 0 && next.X < data.Width && next.Y < data.Height)
                        {
                            if (bits[next.X + (next.Y * data.Stride / 4)] == floodFrom)
                            {
                                check.AddLast(next);
                                bits[next.X + (next.Y * data.Stride / 4)] = floodTo;
                            }
                        }
                    }
                }
            }

            Marshal.Copy(bits, 0, data.Scan0, bits.Length);
            //ビットマップアンロック
            bitmap.UnlockBits(data);
        }
        #endregion
    }
}
