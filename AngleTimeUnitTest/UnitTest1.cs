using Microsoft.VisualStudio.TestTools.UnitTesting;
using AngleTimeOfDay;

namespace AngleTimeUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetHandAngle_1245()
        {
            Assert.AreEqual((90), AngleTimeOfDay.Class1.GetHandAngle(12, 45));
        }
        [TestMethod]
        public void GetHandAngle_1230()
        {
            Assert.AreEqual((180), AngleTimeOfDay.Class1.GetHandAngle(12, 30));
        }
        [TestMethod]
        public void GetHandAngle_315()
        {
            Assert.AreEqual((0), AngleTimeOfDay.Class1.GetHandAngle(3, 15));
        }
        [TestMethod]
        public void GetHandAngle_135()
        {
            Assert.AreEqual((180), AngleTimeOfDay.Class1.GetHandAngle(1, 35));
        }
    }
}
