using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 550;
            int b = 60;
            int result = Lab_1.Program.Example(a, b);
            Assert.AreEqual(9, result);
        }
    }
}
