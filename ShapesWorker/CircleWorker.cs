using System;

namespace ShapesWorker
{
    public class CircleWorker
    {
        public double CalcCircleArea(double radius)
        {
            var s = Math.Pow(radius,2) * Math.PI;
            return Math.Round(s,4);
        }
    }
}