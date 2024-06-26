using System.Windows;

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