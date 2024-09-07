using System.Windows;
using Webshop.ViewModel;

namespace Webshop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainWindowViewModel vm = new MainWindowViewModel();
            DataContext = vm;
		}

        private void btnCreateProfile_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Email er allerede i systemet. Prøv at logge ind", "", button: MessageBoxButton.OK);
        }
    }
}