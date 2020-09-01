using System.Windows;

namespace FunWithVariables
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

        private void ButtonMyMessage_Click(object sender, RoutedEventArgs e)
        {

            string firstName;

            string lastName;

            firstName = textBoxFirstName.Text;

            lastName = textBoxLastName.Text;

            labelMyMessage.Content = "Hello " + firstName + " " + lastName + ", good to see you! ";



        }

        private void buttonClearMe_Click(object sender, RoutedEventArgs e)
        {

            textBoxLastName.Text = "";

            textBoxFirstName.Text = "";

            labelMyMessage.Content = "";


        }
    }
}