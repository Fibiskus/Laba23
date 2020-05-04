using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void TestMethod1()
        {
            int[] a = { 7, 12, 142, -8, 94, 55, 104, 5, 10, 27 };
            int oneDigit = 12;

            double result = ConsoleApp1.Program.min_element(a, oneDigit);

            Assert.AreEqual(oneDigit, result);


        }
    }
}
