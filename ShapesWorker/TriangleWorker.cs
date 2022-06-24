using System;

namespace ShapesWorker
{
    public class TriangleWorker
    {
        public double CalcTriangleArea(double Aside, double Bside, double Cside)
        {
            var p = (Aside + Bside + Cside) / 2;
            var s = Math.Sqrt(p*(p-Aside)*(p-Bside)*(p-Cside));
            return Math.Round(s,4);
        }
        
        //You can extend the class with other methods for calculating the area of a triangle
        
        //Like this
        public double CalcTriangleArea(double basis, double height)
        {
            var s = 0.5 * basis * height;
            return Math.Round(s,4);
        }
        
        public bool IsTriangleRectangular(double Aside, double Bside, double Cside)
        {
            bool result = false;
            if (Math.Pow(Cside, 2)==Math.Pow(Aside, 2) + Math.Pow(Bside, 2))
            {
                result = true;
            }
            return result;
        }
        
    }
}