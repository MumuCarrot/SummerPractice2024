using System.Windows.Controls;

namespace SummerPractice2024
{
    public partial class UserButton : UserControl
    {
        public string SetUsername { set { UserControlButton.Content = value; } }

        public UserButton()
        {
            InitializeComponent();
        }
    }
}
