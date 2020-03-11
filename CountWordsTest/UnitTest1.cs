using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CountWordsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WordCountTest_HelloWorld()
        {
            Assert.AreEqual(2, CountWords.Class1.GetWordCount("Hello World"));
        }
        [TestMethod]
        public void WordCountTest_ILoveProgramming()
        {
            Assert.AreEqual(3, CountWords.Class1.GetWordCount("I l0v3 Programming"));
        }
        [TestMethod]
        public void WordCountTest_Null()
        {
            Assert.AreEqual(0, CountWords.Class1.GetWordCount(""));
        }
        [TestMethod]
        public void WordCountTest_OverCap()
        {
            Assert.AreEqual(-1, CountWords.Class1.GetWordCount("oiuewf oiugwe foiuge wfoiugefw eiuoifwe oiugfs iouu gwgefoiuguwefoiuig wefeoiugwefoiuig wefoiug wesoiug efwiug wfoiuu wefoiugu weoiug foiguakejfnkjesnfkjnsekfjnjskjefnksjnef"));
        }

    }
}
