using SummerPractice2024.Pages;
using SPLibrary;
using System.Windows.Controls;

namespace SummerPractice2024.UserControls
{
    public partial class BookButton : UserControl
    {
        private MainWindow SPParent;
        private Book book; 

        public BookButton(MainWindow parent, Book buttonBook)
        {
            InitializeComponent();

            SPParent = parent;
            book = buttonBook;

            BookControlButton.Content = book.BookName;
        }

        private void BookControlButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            SPParent.InformationFrame.Content = new BookInformationPage(book);
        }
    }
}
