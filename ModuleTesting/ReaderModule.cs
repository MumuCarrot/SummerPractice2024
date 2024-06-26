using C = SPLibrary;

namespace ModuleTesting
{
    [TestClass]
    public class ReaderModule
    {
        [TestMethod]
        public void ReaderReadOnlyString()
        {
            var res = C.Reader.Read("testReaderFile1.txt");

            Assert.IsTrue(res.Count == 1 && res[0] == "User123");
        }

        [TestMethod]
        public void ReaderReadFiveString()
        {
            var res = C.Reader.Read("testReaderFile2.txt");

            Assert.IsTrue(res.Count == 5);
        }

        [TestMethod]
        public void ReaderRaiseException()
        {
            Assert.ThrowsException<Exception>(() => C.Reader.Read(""));
        }
    }
}