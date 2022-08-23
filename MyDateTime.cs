using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace HW_DelegatesAndDevelopments
{
    public class MyDateTime
    {
        public string TimeNow()
        {
            return DateTime.Now.ToString("h:mm:ss tt");
        }
        public string DateNow()
        {
            return DateTime.Now.ToString("yyyy-MM-dd");
        }
        public string DayOfWeek()
        {
            return DateTime.Now.DayOfWeek.ToString();
        }
    }

    public class FigureArea
    {
        public double TriangleArea(double n1, double n2, double ang)
        {
            return 0.5 * (n1 * n2) * (Sin(ang));
        }

        public double RectangleArea(double n1, double n2, double ang)
        {
            return 0.5 * (n1 * n2) * (Sin(ang));
        }
    }
}
