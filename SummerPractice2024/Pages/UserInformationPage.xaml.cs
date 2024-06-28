using System.Windows.Controls;
using SPLibrary;

namespace SummerPractice2024.Pages
{
    public partial class UserInformationPage : Page
    {
        private Customer _user;

        public UserInformationPage(Customer user)
        {
            InitializeComponent();

            _user = user;

            Id.Text = _user.Id;
            Nickname.Text = _user.Nickname;
            Lastname.Text = _user.LastName;
            Name.Text = _user.Name;
            PhoneNumber.Text = _user.PhoneNumber;
            Adress.Text = _user.Adress;
        }
    }
}
