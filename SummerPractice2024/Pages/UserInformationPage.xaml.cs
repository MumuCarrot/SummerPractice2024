using System.Windows.Controls;

namespace SummerPractice2024.Pages
{
    public partial class UserInformationPage : Page
    {
        private string _username;

        public UserInformationPage(string username)
        {
            InitializeComponent();

            _username = username;

            Username.Text = _username;
        }
    }
}
