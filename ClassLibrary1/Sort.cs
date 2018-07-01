using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortLibrary
{// сортировка точек на плоскости по х(или у, если х1=х2) простым включением
    public class Point
    {
        public int x;
        public int y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public class ConvertTextBoxToPoints
    {
        public static Point[] ConvertToPoints(TextBox textBox)
        {
            string[] arrstd = textBox.Text.Split(new char[] { ' ', '\n', '\r', ',' }, StringSplitOptions.RemoveEmptyEntries);
            Point[] points = new Point[arrstd.Length / 2];
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point(Convert.ToInt32(arrstd[2 * i]), Convert.ToInt32(arrstd[2 * i + 1]));
            }
            return points;
        }

        public static string[] ConvertToStringArr(Point[] points)
        {
            List<string> arrstr = new List<string>();
            for (int i = 0; i < points.Length; i++)
            {
                arrstr.Add(Convert.ToString(points[i].x) + ' ' + Convert.ToString(points[i].y));
            }
            return arrstr.ToArray();
        }
    }
    public class Sort
    {
        /*
         * 8 5 3 0 7 3 5 2 4 6  5
         * 8 8 3 0 7 3 5 2 4 6
         * 5 8 3 0 7 3 5 2 4 6  3
         * 5 5 8 0 7 3 5 2 4 6
         * 3 5 8 0 7 3 5 2 4 6  0
         * 3 3 5 8 7 3 5 2 4 6
         * 0 3 5 8 7 3 5 2 4 6  7
         * 0 3 5 7 8 3 5 2 4 6 
         * 0 3 5 7 8 3 5 2 4 6  3
        
        */
        private static int SravPoints(Point point1, Point point2)
        {
            /*if (point1.x > point2.x)
                return 1;
            if (point1.x < point2.x)
                return -1;
            if (point1.y > point2.y)
                return 1;
            if (point1.y < point2.y)
                return -1;
            return 0;
            */
            if ((point1.x > point2.x) || (point1.x == point2.x && point1.y > point2.y))
            {
                return 1;
            }
            if (point1.x == point2.x && point1.y == point2.y)
            {
                return 0;
            }
            return -1;
        }

        public static void SortInsertPoints(Point[] points, bool flag)
        {
            for (int i = 1; i < points.Length; i++)
            {
                Point x = points[i];
                int j = i - 1;
                int koef = SravPoints(points[j], x);//как относятся друг к другу две точки
                while ((j >= 0) && ((koef > 0 && flag) || (koef < 0 && !flag)))
                {
                    points[j + 1] = points[j];
                    j--;
                }
                points[j + 1] = x;
            }

        }
    }
}
