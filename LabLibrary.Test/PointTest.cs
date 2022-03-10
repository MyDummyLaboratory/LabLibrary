using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace LabLibrary.Test
{
    [TestClass]
    public class PointTest
    {
        [TestMethod]
        public void Point_Constructor()
        {
            LabLibrary.Point point = new LabLibrary.Point(1,2,3);
            Assert.AreEqual(point.X, 1, 1e-8);
            Assert.AreEqual(point.Y, 2, 1e-8);
            Assert.AreEqual(point.Z, 3, 1e-8);
        }
    }
}
