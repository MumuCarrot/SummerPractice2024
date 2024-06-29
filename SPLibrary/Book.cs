using System.Xml.Linq;

namespace SPLibrary
{
    public class Book : IContainer
    {
        public string BookName { get; set; } = string.Empty;
        public string BookDesk { get; set; } = string.Empty;
        public string BookAuthor { get; set; } = string.Empty;
        public string Handler { get; set; } = string.Empty;
        public string ExpiredDate { get; set; } = string.Empty;

        public override string ToString() => $"{BookName};{BookDesk};{BookAuthor};{Handler};{ExpiredDate}";

        public bool IsEmpty { get => BookName == string.Empty && BookDesk == string.Empty && BookAuthor == string.Empty && Handler == string.Empty && ExpiredDate == string.Empty; }
    }
}
