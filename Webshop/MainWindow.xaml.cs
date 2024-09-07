using System.Collections.Frozen;
using System.Windows;
using Webshop.View;
using Webshop.ViewModel;
using Webshop.Model;

namespace Webshop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        MainWindowViewModel vm;

        public MainWindow()
        {
            InitializeComponent();
            vm = new MainWindowViewModel();
            DataContext = vm;
		}

        private void btnCreateProfile_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Email er allerede i systemet. Prøv at logge ind", "", button: MessageBoxButton.OK);
        }

        private void btnLogIn_Click(object sender, RoutedEventArgs e)
        {
            if (vm.Login(txtProfileEmail.Text))
            {
                List<Customer> list = vm.Customers.ToList();
                CustomerView newWindow = new CustomerView(list.Find(c => c.Email == txtProfileEmail.Text));
                newWindow.Show();

                this.Close();
            }

            else
            {
                MessageBox.Show("Email er ikke registreret. Prøv at registre dig", "", button: MessageBoxButton.OK);
            }
        }
    }
}