using C = SPLibrary;

namespace ModuleTesting
{
    [TestClass]
    public class WriterModule
    {
        [TestMethod]
        public void WriterListZeroCountString()
        {
            List<C.Book> writedBookList = new();

            string fileName = "testWriterFile0.txt";

            string path = @"..\..\..\Data\" + fileName;

            bool isWrited = C.Writer.WriteListToTxt(writedBookList, fileName);

            if (File.Exists(path)) File.Delete(path);

            Assert.IsTrue(!isWrited);
        }

        [TestMethod]
        public void WriterWriteBookListStringAllFields()
        {
            string fileName = "testWriterFile1.txt";

            string path = @"..\..\..\Data\" + fileName;
            try
            {
                List<C.Book> writedBookList = new()
                {
                    new C.Book() { BookName = "Test", BookAuthor = "Test", BookDesk = "Test", ExpiredDate = "Test", Handler = "Test" },
                    new C.Book() { BookName = "Test", BookAuthor = "Test", BookDesk = "Test", ExpiredDate = "Test", Handler = "Test" },
                    new C.Book() { BookName = "Test", BookAuthor = "Test", BookDesk = "Test", ExpiredDate = "Test", Handler = "Test" },
                };


                bool isWrited = C.Writer.WriteListToTxt(writedBookList, fileName);

                List<C.Book> readedBookList = C.Parser.ParseToBook(C.Reader.Read(fileName));


                Assert.IsTrue(isWrited && writedBookList.Count == readedBookList.Count);
            }
            finally
            {
                if (File.Exists(path)) File.Delete(path);
            }
        }

        [TestMethod]
        public void WriterWriteCustomerListStringAllFields()
        {
            string fileName = "testWriterFile2.txt";

            string path = @"..\..\..\Data\" + fileName;
            try
            {
                List<C.Customer> writedCustomerList = new()
                {
                    new C.Customer() { Adress = "Test", Id = "Test", LastName = "Test", Name = "Test", Nickname = "Test", PhoneNumber = "Test" },
                    new C.Customer() { Adress = "Test", Id = "Test", LastName = "Test", Name = "Test", Nickname = "Test", PhoneNumber = "Test" },
                    new C.Customer() { Adress = "Test", Id = "Test", LastName = "Test", Name = "Test", Nickname = "Test", PhoneNumber = "Test" },
                };


                bool isWrited = C.Writer.WriteListToTxt(writedCustomerList, fileName);

                List<C.Customer> readedCustomerList = C.Parser.ParseToCustomer(C.Reader.Read(fileName));

                Assert.IsTrue(isWrited && writedCustomerList.Count == readedCustomerList.Count);
            }
            finally
            {
                if (File.Exists(path)) File.Delete(path);
            }
        }

        [TestMethod]
        public void WriterWriteBookListStringPartialFields()
        {
            string fileName = "testWriterFile3.txt";

            string path = @"..\..\..\Data\" + fileName;
            try
            {
                List<C.Book> writedBookList = new()
                {
                    new C.Book() { BookName = "Test", BookAuthor = "Test", BookDesk = "Test"},
                    new C.Book() { BookName = "Test", ExpiredDate = "Test", Handler = "Test" },
                    new C.Book() {  BookAuthor = "Test", BookDesk = "Test", ExpiredDate = "Test", Handler = "Test" },
                };


                bool isWrited = C.Writer.WriteListToTxt(writedBookList, fileName);

                List<C.Book> readedBookList = C.Parser.ParseToBook(C.Reader.Read(fileName));


                Assert.IsTrue(isWrited && writedBookList.Count == readedBookList.Count);
            }
            finally
            {
                if (File.Exists(path)) File.Delete(path);
            }
        }

        [TestMethod]
        public void WriterWriteCustomerListStringPartialFields()
        {
            string fileName = "testWriterFile4.txt";

            string path = @"..\..\..\Data\" + fileName;
            try
            {
                List<C.Customer> writedCustomerList = new()
                {
                    new C.Customer() { Adress = "Test", Id = "Test", LastName = "Test", Name = "Test" },
                    new C.Customer() { Adress = "Test", Id = "Test", Nickname = "Test", PhoneNumber = "Test" },
                    new C.Customer() { LastName = "Test", Name = "Test", Nickname = "Test", PhoneNumber = "Test" },
                };


                bool isWrited = C.Writer.WriteListToTxt(writedCustomerList, fileName);

                List<C.Customer> readedCustomerList = C.Parser.ParseToCustomer(C.Reader.Read(fileName));

                Assert.IsTrue(isWrited && writedCustomerList.Count == readedCustomerList.Count);
            }
            finally
            {
                if (File.Exists(path)) File.Delete(path);
            }
        }
    }
}
