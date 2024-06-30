using System.Windows;
using System.Windows.Controls;
using SPLibrary;
using SummerPractice2024.UserControls;

namespace SummerPractice2024.Pages
{
    public partial class UserInformationPage : Page
    {
        private readonly MainWindow _mainWindow;
        private Customer _user;
        private List<Book> _currentUserBookList;

        public UserInformationPage(MainWindow mainWindow, Customer user, List<Book> currentUserBookList)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
            _user = user;
            _currentUserBookList = currentUserBookList;

            BookStack.Children.Clear();

            foreach (var book in _currentUserBookList) 
            {
                BookStack.Children.Add(new UserBookElement(_mainWindow, book));
            }

            Id.Text = _user.Id;
            Nickname.Text = _user.Nickname;
            Lastname.Text = _user.LastName;
            Name.Text = _user.Name;
            PhoneNumber.Text = _user.PhoneNumber;
            Adress.Text = _user.Adress;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Customer user = new()
            {
                Id = Id.Text,
                Nickname = Nickname.Text,
                LastName = Lastname.Text,
                Name = Name.Text,
                PhoneNumber = PhoneNumber.Text,
                Adress = Adress.Text
            };

            if (!user.IsEmpty)
            { 
                _user = user;

                bool userExists = false;
                foreach (var u in _mainWindow.UserList)
                {
                    if (u.Id == _user.Id)
                    {
                        u.Nickname = _user.Nickname;
                        u.LastName = _user.LastName;
                        u.Name = _user.Name;
                        u.PhoneNumber = _user.PhoneNumber;
                        u.Adress = _user.Adress;
                        userExists = true;
                        break;
                    }
                }

                if (!userExists)
                {
                    _mainWindow.UserList.Add(_user);
                }

                _mainWindow.Button_Click(sender, e);
                _mainWindow.UpdateBookLists();

                Writer.WriteListToTxt(_mainWindow.UserList, "users.txt");
            }
        }
    }
}
