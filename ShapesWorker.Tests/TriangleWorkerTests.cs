using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShapesWorker.Tests
{
    [TestClass]
    public class TriangleWorkerTests
    {
        [TestMethod]
        public void CalcTriangleArea_3and4and5_6_returned()
        {
            //arrange
            double Aside = 3;
            double Bside = 4;
            double Cside = 5;
            double expected = 6;
            
            //act
            TriangleWorker tw = new TriangleWorker();
            double actual = tw.CalcTriangleArea(Aside, Bside, Cside);
            
            //assert
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void CalcTriangleArea_5and15_37_returned()
        {
            //arrange 
            double basis = 5;
            double height = 15;
            double expected = 37.5000;
            
            //act
            TriangleWorker tw = new TriangleWorker();
            double actual = tw.CalcTriangleArea(basis, height);
            
            //assert
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void IsTriangleRectangular_3and4and5_true_returned()
        {
            //arrange
            double Aside = 3;
            double Bside = 4;
            double Cside = 5;
            bool expected = true;
            
            //act
            TriangleWorker tw = new TriangleWorker();
            bool actual = tw.IsTriangleRectangular(Aside, Bside, Cside);
            
            //assert
            Assert.AreEqual(expected,actual);
        }
    }
}