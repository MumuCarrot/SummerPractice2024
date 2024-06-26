using C = SPLibrary;

namespace ModuleTesting
{
    [TestClass]
    public class ParserModule
    {
        [TestMethod]
        public void ParserParseOnlyToBook()
        {
            var list = C.Reader.Read("testParserDataFile1.txt");

            Assert.IsTrue(C.Parser.ParseToBook(list).Count == 1);
        }

        [TestMethod]
        public void ParserParseFiveToBook()
        {
            var list = C.Reader.Read("testParserDataFile2.txt");

            Assert.IsTrue(C.Parser.ParseToBook(list).Count == 5);
        }

        [TestMethod]
        public void ParserParseRaiseExceptionOfNoElements()
        {
            var list = C.Reader.Read("testParserDataFile3.txt");

            Assert.ThrowsException<Exception>(() => C.Parser.ParseToBook(list));
        }

        [TestMethod]
        public void ParserParseRaiseExceptionBrokenElement()
        {
            var list = C.Reader.Read("testParserDataFile3.txt");

            Assert.ThrowsException<Exception>(() => C.Parser.ParseToBook(list));
        }
    }
}