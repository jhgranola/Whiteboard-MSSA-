using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WhiteboardPractice1Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetReverse_SuperBowl()
        {
            Assert.AreEqual("lwoB repuS", WhiteboardPractice1.Program.GetReverse("Super Bowl"));
        }
        [TestMethod]
        public void GetReverse_ILikeDogs()
        {
            Assert.AreEqual("sgoD ekiL I", WhiteboardPractice1.Program.GetReverse("I Like Dogs"));
        }
    }
}
