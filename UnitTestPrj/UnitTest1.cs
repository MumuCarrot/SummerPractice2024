using SummerPractice2024;

namespace UnitTestPrj
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            TestClass.First = 2;
            TestClass.Second = 2;

            Assert.AreEqual(4, TestClass.Summary());
        }
    }
}