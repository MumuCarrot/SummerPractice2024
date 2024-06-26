using SummerPractice2024;

namespace TestTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            TestClass.First = 2;
            TestClass.Second = 3;

            Assert.AreEqual(5, TestClass.Summary());
        }
    }
}