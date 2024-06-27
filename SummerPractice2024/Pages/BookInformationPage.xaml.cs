using System.Windows.Controls;
using SPLibrary;

namespace SummerPractice2024.Pages
{
    public partial class BookInformationPage : Page
    {
        private Book _book;

        public BookInformationPage(Book book)
        {
            InitializeComponent();
            _book = book;

            BookName.Text = _book.BookName;
            BookDesk.Text = _book.BookDesk;
            BookAuthor.Text = _book.BookAuthor;
        }
    }
}
