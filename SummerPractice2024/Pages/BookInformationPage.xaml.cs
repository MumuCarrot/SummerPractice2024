using SPLibrary;
using System.Windows;
using System.Windows.Controls;
using static System.Reflection.Metadata.BlobBuilder;

namespace SummerPractice2024.Pages
{
    public partial class BookInformationPage : Page
    {
        private readonly MainWindow _mainWindow;
        private Book _book;

        public BookInformationPage(MainWindow mainWindow, Book book)
        {
            InitializeComponent();
            this._mainWindow = mainWindow;
            _book = book;

            BookName.Text = _book.BookName;
            BookDesk.Text = _book.BookDesk;
            BookAuthor.Text = _book.BookAuthor;
            Handler.Text = _book.Handler;
            ExpiredDate.Text = _book.ExpiredDate;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Book book = new()
            {
                BookName = BookName.Text,
                BookDesk = BookDesk.Text,
                BookAuthor = BookAuthor.Text,
                Handler = Handler.Text,
                ExpiredDate = ExpiredDate.Text,
            };

            if (!book.IsEmpty)
            {
                _book = book;

                bool bookExists = false;
                foreach (var b in _mainWindow.BookList)
                {
                    if (b.BookName == _book.BookName)
                    {
                        b.BookDesk = _book.BookDesk;
                        b.BookAuthor = _book.BookAuthor;
                        b.Handler = _book.Handler;
                        b.ExpiredDate = _book.ExpiredDate;
                        bookExists = true;
                        break;
                    }
                }

                if (!bookExists)
                {
                    _mainWindow.BookList.Add(_book);
                }

                _mainWindow.Button_Click(sender, e);
                _mainWindow.UpdateBookLists();

                Writer.WriteListToTxt(_mainWindow.BookList, "books.txt");
            }
        }
    }
}
