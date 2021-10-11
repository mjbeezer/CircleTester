using System;
using System.Collections.Generic;
using System.Text;

namespace Circle_Lab
{
    class Circles
    {
        private double _radius;
        public double Circumference;
        public double Area;

        public double Radius
        {
            get { return _radius; }
            set { this._radius = value; }
        }
        //constructor
        public Circles(double radius)
        {
            this._radius = radius;
        }
        //methods
        public double CalculateCircumference()
        {
            return 2 * Math.PI * this._radius;
        }
        
        public string CalculateFormattedCircumference()
        {
            double circle = CalculateCircumference();
            return FormatNumber(circle);
        }

        public double CalculateArea()
        {
            return Math.PI * this._radius * this._radius;
        }

        public string CalculateFormattedArea()
        {
            double area = CalculateArea();
            return FormatNumber(area);
        }

        private string FormatNumber(double x)
        {
            return Math.Round(x, 2).ToString();
        }
    }
}

