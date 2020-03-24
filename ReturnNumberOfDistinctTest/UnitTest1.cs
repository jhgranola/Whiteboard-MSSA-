using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReturnNumberOfDistinct;

namespace ReturnNumberOfDistinctTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(3, ReturnNumberOfDistinct.Class1.CountDistinctElements(new int[] {1, 3, 5, 5, 3, 1 }));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(5, ReturnNumberOfDistinct.Class1.CountDistinctElements(new int[] { 12, 1, 15, 12, 12, 13, 1, 27, 27}));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(8, ReturnNumberOfDistinct.Class1.CountDistinctElements(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }));
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(1, ReturnNumberOfDistinct.Class1.CountDistinctElements(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1 }));
        }
    }
}
