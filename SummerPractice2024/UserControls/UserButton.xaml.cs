using SummerPractice2024.Pages;
using SPLibrary;
using System.Windows.Controls;

namespace SummerPractice2024
{
    public partial class UserButton : UserControl
    {
        private MainWindow SPParent;
        private Customer _username;

        public UserButton(MainWindow parent, Customer username)
        {
            InitializeComponent();

            SPParent = parent;
            _username = username;

            UserControlButton.Content = _username.Nickname;
        }

        private void UserControlButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            SPParent.InformationFrame.Content = new UserInformationPage(_username);
        }
    }
}
