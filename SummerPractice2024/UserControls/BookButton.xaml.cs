using System.Windows.Controls;
using SPLibrary;

namespace SummerPractice2024.UserControls
{
    public partial class BookButton : UserControl
    {
        private Book book; 

        public BookButton(Book buttonBook)
        {
            InitializeComponent();

            book = buttonBook;

            BookControlButton.Content = book.BookName;
        }
    }
}
