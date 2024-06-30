using System.Windows;
using System.Windows.Controls;
using SPLibrary;
using SummerPractice2024.Pages;

namespace SummerPractice2024.UserControls
{
    public partial class UserBookElement : UserControl
    {
        private Book _book;
        private MainWindow _mainWindow;

        public UserBookElement(MainWindow mainWindow, Book book)
        {
            InitializeComponent();

            _mainWindow = mainWindow;
            _book = book;

            BookButton.Content = $"{book.BookName} | {book.ExpiredDate}";
        }

        private void BookButton_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.InformationFrame.Content = new BookInformationPage(_mainWindow, _book);
        }
    }
}
