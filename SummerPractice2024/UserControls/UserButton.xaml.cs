using SummerPractice2024.Pages;
using SPLibrary;
using System.Windows.Controls;

namespace SummerPractice2024
{
    public partial class UserButton : UserControl
    {
        private MainWindow _mainWindow;
        private Customer _customer;

        public UserButton(MainWindow parent, Customer username)
        {
            InitializeComponent();

            _mainWindow = parent;
            _customer = username;

            UserControlButton.Content = _customer.Nickname;
        }

        private void UserControlButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var handlerList = from b in _mainWindow.BookListWithHandler where b.Handler.Equals(_customer.Nickname) select b;

            _mainWindow.InformationFrame.Content = new UserInformationPage(_mainWindow, _customer, handlerList.ToList());
        }
    }
}
