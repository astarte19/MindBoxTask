using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShapesWorker.Tests
{
    [TestClass]
    public class CircleWorkerTests
    {
        [TestMethod]
        public void CalcCircleArea_4_50_returned()
        {
            //arrange
            double radius = 4;
            double expected = 50.2655;
            
            //act
            CircleWorker cw = new CircleWorker(radius);
            double actual = cw.CalcCircleArea();
            
            //assert
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void CalcCirclePerimeter_15_94_returned()
        {
            //arrange
            double radius = 15;
            double expected = 94.2478;
            
            //act
            CircleWorker cw = new CircleWorker(radius);
            double actual = cw.CalcCirclePerimeter();
            
            //assert
            Assert.AreEqual(expected,actual);
        }
    }
}