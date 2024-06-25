using System.Windows;

namespace SummerPractice2024
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TestClass.First = int.Parse(FirstTB.Text);
            TestClass.Second = int.Parse(SecondTB.Text);
            Answer.Text = TestClass.Summary().ToString();
        }
    }
}