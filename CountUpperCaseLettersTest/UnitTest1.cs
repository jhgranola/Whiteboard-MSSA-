using Microsoft.VisualStudio.TestTools.UnitTesting;
using CountUpperCaseLetters;
namespace CountUpperCaseLettersTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(3, Class1.CountUpper("San Diego Zoo"));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(4, Class1.CountUpper("OnceUponATime"));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(5, Class1.CountUpper("ThereShouldBeFiveUppercase"));
        }
    }
}
