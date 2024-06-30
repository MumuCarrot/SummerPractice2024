using System.Windows;
using SPLibrary;
using SummerPractice2024.Pages;
using SummerPractice2024.UserControls;

namespace SummerPractice2024
{
    public partial class MainWindow : Window
    {
        public List<Customer> UserList = Parser.ParseToCustomer(Reader.Read("users.txt"));
        public List<Book> BookList = Parser.ParseToBook(Reader.Read("books.txt"));
        public List<Book> BookListWithHandler = new();
        public List<Book> BookListWithoutHandler = new();

        public MainWindow()
        {
            InitializeComponent();

            LeftBtn.IsChecked = true;
            Button_Click(null, null);

            UpdateBookLists();
        }

        public void UpdateBookLists() 
        {
            foreach (var book in BookList)
            {
                if (book.Handler == string.Empty)
                {
                    BookListWithoutHandler.Add(book);
                }
                else
                {
                    BookListWithHandler.Add(book);
                }
            }
        }

        private void LeftBtn_Checked(object sender, RoutedEventArgs e)
        {
            RightBtn.IsChecked = false;
        }

        private void RightBtn_Checked(object sender, RoutedEventArgs e)
        {
            LeftBtn.IsChecked = false;
        }

        public void Button_Click(object? sender, RoutedEventArgs? e)
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
            else foreach (var book in BookListWithoutHandler) ContentStack.Children.Add(new BookButton(this, book));
        }

        private void CreateNewElement_Click(object sender, RoutedEventArgs e)
        {
            if (LeftBtn.IsChecked is not null && (bool)LeftBtn.IsChecked)
            {
                Customer customer = new()
                {
                    Id = (UserList.Where(c => int.TryParse(c.Id, out _)).Select(c => int.Parse(c.Id)).Max() + 1).ToString()
                };

                var handlerList = from b in BookListWithHandler where b.Handler.Equals(customer.Nickname) select b;

                InformationFrame.Content = new UserInformationPage(this, customer, handlerList.ToList());
            }
            else if (RightBtn.IsChecked is not null && (bool)RightBtn.IsChecked) 
            {
                Book book = new Book();

                InformationFrame.Content = new BookInformationPage(this, book);
            }
        }
    }
}