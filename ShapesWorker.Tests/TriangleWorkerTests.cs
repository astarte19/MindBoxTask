using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShapesWorker.Tests
{
    [TestClass]
    public class TriangleWorkerTests
    {
        [TestMethod]
        public void CalcTriangleAreaBySides_3and4and5_6_returned()
        {
            //arrange
            double Aside = 3;
            double Bside = 4;
            double Cside = 5;
            double expected = 6;
            
            //act
            TriangleWorker tw = new TriangleWorker(Aside, Bside, Cside);
            double actual = tw.CalcTriangleAreaBySides();
            
            //assert
            Assert.AreEqual(expected,actual);
        }


        [TestMethod]
        public void CalcTrianglePerimeter_3and4and5_12_returned()
        {
            //arrange
            double Aside = 3;
            double Bside = 4;
            double Cside = 5;
            double expected = 12;
            
            //act
            TriangleWorker tw = new TriangleWorker(Aside, Bside, Cside);
            double actual = tw.CalcTrianglePerimeter();
            
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
            TriangleWorker tw = new TriangleWorker(Aside, Bside, Cside);
            bool actual = tw.IsTriangleRectangular();
            
            //assert
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void IsTriangleExist_4and6and7_true__returned()
        {
            //arrange
            double Aside = 4;
            double Bside = 6;
            double Cside = 7;
            bool expected = true;
            
            //act
            TriangleWorker tw = new TriangleWorker(Aside, Bside, Cside);
            bool actual = tw.IsTriangleExist(Aside, Bside, Cside);
            
            //assert
            Assert.AreEqual(expected,actual);
        }
    }
}