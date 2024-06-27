namespace SPLibrary
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
                    string[] parts = book.Split(new[] { ';' });

                    if (parts.Length >= 5)
                    {
                        bookList.Add(new Book()
                        {
                            BookName = (string.IsNullOrWhiteSpace(parts[0]) ? null : parts[0].Trim()) ?? "",
                            BookDesk = (string.IsNullOrWhiteSpace(parts[1]) ? null : parts[1].Trim()) ?? "",
                            BookAuthor = (string.IsNullOrWhiteSpace(parts[2]) ? null : parts[2].Trim()) ?? "",
                            Handler = (string.IsNullOrWhiteSpace(parts[3]) ? null : parts[3].Trim()) ?? "",
                            ExpiredDate = (string.IsNullOrWhiteSpace(parts[4]) ? null : parts[4].Trim()) ?? ""
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
