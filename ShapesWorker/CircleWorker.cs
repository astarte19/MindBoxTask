using System;

namespace ShapesWorker
{
    public class CircleWorker : Figure
    {
        public double Radius { get; set; }
        public CircleWorker(double radius)
        {
            if (radius>0)
            {
                Radius = radius;
            }
            else
            {
                Console.WriteLine("Radius can't be null!");
            }
        }
        public double CalcCircleArea()
        {
            double s = Math.Pow(Radius,2) * Math.PI;
            Area = Math.Round(s, 4);
            return Area;
        }
        public double CalcCirclePerimeter()
        {
            double p = Math.PI * 2 * Radius;
            Perimeter = Math.Round(p, 4);
            return Perimeter;
        }
    }
}