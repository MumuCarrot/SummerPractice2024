using System.Windows;
using SPLibrary;
using SummerPractice2024.UserControls;

namespace SummerPractice2024
{
    public partial class MainWindow : Window
    {
        private List<Customer> UserList = Parser.ParseToCustomer(Reader.Read("users.txt"));
        private List<Book> BookList = Parser.ParseToBook(Reader.Read("books.txt"));

        public MainWindow()
        {
            InitializeComponent();

            LeftBtn.IsChecked = true;
            Button_Click(null, null);
        }

        private void LeftBtn_Checked(object sender, RoutedEventArgs e)
        {
            RightBtn.IsChecked = false;
        }

        private void RightBtn_Checked(object sender, RoutedEventArgs e)
        {
            LeftBtn.IsChecked = false;
        }

        private void Button_Click(object? sender, RoutedEventArgs? e)
        {
            if (LeftBtn.IsChecked is not null && (bool)LeftBtn.IsChecked)
            {
                ChargeStack();
            }
            else if (RightBtn.IsChecked is not null && (bool)RightBtn.IsChecked)
            {
                ChargeStack();
            }
            else 
            {
                LeftBtn.IsChecked = true;
                ChargeStack();
            }
        }

        private void ChargeStack() 
        {
            ContentStack.Children.Clear();
            if (LeftBtn.IsChecked is not null && (bool)LeftBtn.IsChecked) foreach (var user in UserList) ContentStack.Children.Add(new UserButton(this, user));
            else foreach (var book in BookList) ContentStack.Children.Add(new BookButton(this, book));
        }
    }
}