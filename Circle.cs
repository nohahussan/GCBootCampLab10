using System;
namespace Lab10
{
    public class Circle
    {
        public static int numberOfCircles = 0;
        private double radius;
        public double Radius//property
        {
            get { return radius; }
        }
        //constructor
        public Circle(double radius)
        {
            this.radius = radius;
            numberOfCircles++;
        }
        public double CalculateCircumference()
        {
            double circumference = (2 * radius * Math.PI);
            return circumference;
        }
        public string CalculateFormattedCircumference()
        {
            string FormattedCircumference = "Circumference: ";
            FormattedCircumference+= FormatNumber(CalculateCircumference());
            return FormattedCircumference;
        }
        public double CalculateArea()
        {
            double area = Math.PI * (Math.Pow(radius,2));
            return area;
        }
        public string CalculateFormattedArea()
        {
            string FormattedArea = "Aea: ";
            FormattedArea += FormatNumber(CalculateArea());
            return FormattedArea;
        }
        private string FormatNumber(double x)
        {
            string roundedNumber = "";
            roundedNumber += Math.Round(x, 2);
            return roundedNumber;
        }



    }
}
