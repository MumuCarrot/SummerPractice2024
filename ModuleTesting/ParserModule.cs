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
        public void ParserParseRaiseExceptionOfNoElementsBook()
        {
            var list = C.Reader.Read("testParserDataFile3.txt");

            Assert.ThrowsException<Exception>(() => C.Parser.ParseToBook(list));
        }

        [TestMethod]
        public void ParserParseRaiseExceptionBrokenElementBook()
        {
            var list = C.Reader.Read("testParserDataFile4.txt");

            Assert.ThrowsException<Exception>(() => C.Parser.ParseToBook(list));
        }

        [TestMethod]
        public void ParserParseOnlyToCustomer()
        {
            var list = C.Reader.Read("testParserDataFile5.txt");

            Assert.IsTrue(C.Parser.ParseToCustomer(list).Count == 1);
        }

        [TestMethod]
        public void ParserParseFiveToCustomer()
        {
            var list = C.Reader.Read("testParserDataFile6.txt");

            Assert.IsTrue(C.Parser.ParseToCustomer(list).Count == 5);
        }

        [TestMethod]
        public void ParserParseRaiseExceptionOfNoCustomers()
        {
            var list = C.Reader.Read("testParserDataFile7.txt");

            Assert.ThrowsException<Exception>(() => C.Parser.ParseToCustomer(list));
        }

        [TestMethod]
        public void ParserParseRaiseExceptionBrokenElementCustomer()
        {
            var list = C.Reader.Read("testParserDataFile8.txt");

            Assert.ThrowsException<Exception>(() => C.Parser.ParseToBook(list));
        }

    }
}