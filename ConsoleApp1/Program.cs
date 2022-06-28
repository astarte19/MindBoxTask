using System;
using ShapesWorker;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            TriangleWorker tw = new TriangleWorker(3, 4, 5);
            
            
            
            Console.WriteLine(tw.CalcTrianglePerimeter());
        }
    }
}