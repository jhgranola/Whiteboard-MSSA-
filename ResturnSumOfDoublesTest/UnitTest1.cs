using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReturnSumOfDoubles;

namespace ReturnSumOfDoublesTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(38.0, ReturnSumOfDoubles.Class1.GetSum(new double[] { 12.5, 9.2, 8.3, 4.5, 3.5 }));
        }
        [TestMethod]
        public void TestMethod2()
        { 
            Assert.AreEqual(99.2, ReturnSumOfDoubles.Class1.GetSum(new double[] { 15.2, 16.6, 19.4, 28.7, 19.3 }));
        }
    }
}
