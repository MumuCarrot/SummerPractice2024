using System.Windows;
using SPLibrary;

namespace SummerPractice2024
{
    public partial class MainWindow : Window
    {
        private List<string> UserList = Reader.Read("users.txt");
        private List<Book> BooksList = Parser.ParseToBook(Reader.Read("books.txt"));

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}