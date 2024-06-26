namespace SummerPractice2024
{
    public static class Parser
    {
        public static List<Book> ParseToBook(List<string> stringBookList)
        {
            if (stringBookList.Count > 0)
            {
                List<Book> bookList = new List<Book>();
                foreach (string book in stringBookList)
                {
                    string[] parts = book.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                    if (parts.Length >= 5)
                    {
                        bookList.Add(new Book()
                        {
                            BookName = parts[0].Trim(),
                            BookDesk = parts[1].Trim(),
                            BookAuthor = parts[2].Trim(),
                            Handler = parts[3].Trim(),
                            ExpiredDate = parts[4].Trim()
                        });
                    }
                    else
                    {
                        throw new Exception("Error: Not enough data to create a Book object.");
                    }
                }
                return bookList;
            }
            else throw new Exception("Parser error: list count is 0!");
        }
    }
}
