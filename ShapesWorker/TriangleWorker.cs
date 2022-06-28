using System;

namespace ShapesWorker
{
    public class TriangleWorker : Figure
    {
        //Разносторонний
        public double SideA { get; set; }
        public double SideB { get; set; }
        public  double SideC { get; set; }
        
        public TriangleWorker(double SideA,double SideB,double SideC )
        {
            if (SideA > 0 && SideB > 0 && SideC > 0)
            {
                if (IsTriangleExist(SideA,SideB,SideC))
                {
                    this.SideA = SideA;
                    this.SideB = SideB;
                    this.SideC = SideC;
                    
                }
                else
                {
                    Console.WriteLine("This triangle does not exist!");
                }
            }
            else
            {
                Console.WriteLine("Sides must be greater than zero!");
            }
            
        }
        
        public double CalcTriangleAreaBySides()
        {
            double p = (SideA + SideB + SideC) / 2;
            double s = Math.Sqrt(p*(p-SideA)*(p-SideB)*(p-SideC));
            Area = Math.Round(s,4);
            return Area;
        }
        
        public double CalcTrianglePerimeter()
        {
            double p = SideA + SideB + SideC;
            Perimeter = Math.Round(p, 4);
            return Perimeter;
        }
        
        public bool IsTriangleRectangular()
        {
            bool result = false;
            bool isAHypotenuse = Math.Pow(SideA, 2) == Math.Pow(SideB, 2) + Math.Pow(SideC, 2);
            bool isBHypotenuse = Math.Pow(SideB, 2) == Math.Pow(SideA, 2) + Math.Pow(SideC, 2);
            bool isCHypotenuse = Math.Pow(SideC, 2) == Math.Pow(SideA, 2) + Math.Pow(SideB, 2);
            if (isAHypotenuse || isBHypotenuse || isCHypotenuse)
            {
                result = true;
            }
            
            return result;
        }
        
            
        public bool IsTriangleExist(double Aside, double Bside, double Cside)
        {
            bool isExist = false;
            if (Aside < Bside+Cside && Bside < Aside+Cside && Cside < Aside+Bside)
            {
                isExist = true;
            }

            return isExist;
        }
        
    }
}