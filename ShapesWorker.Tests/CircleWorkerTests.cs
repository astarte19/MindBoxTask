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
            CircleWorker cw = new CircleWorker();
            double actual = cw.CalcCircleArea(radius);
            
            //assert
            Assert.AreEqual(expected,actual);
        }
    }
}