using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleLab
{
    class Circles
    {
        public class Circle
        {
            private double radius;
            public double Radius
            {
                get
                {
                    return radius;
                }
                set
                {
                    radius = value;
                }
            }
            public Circle(double radius)
            {
                this.radius = radius;
            }
            public double CalculateCircumference()
            {
                return 2 * System.Math.PI * radius;
            }
            public string CalculateFormattedCircumference()
            {
                return FormatNumber(CalculateCircumference());
            }
            public double CalculateArea()
            {
                return System.Math.PI * radius * radius;
            }
            public string CalculateFormattedArea()
            {
                return FormatNumber(CalculateArea());
            }
            private string FormatNumber(double x)
            {
                return x.ToString("0.##");
            }
        }
    }
}
