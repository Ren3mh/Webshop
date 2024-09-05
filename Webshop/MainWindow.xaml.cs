using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
            bt_Pay.IsEnabled = false;
			String[] PaymentMethods = { "Kreditkort", "Mobilepay", "Paypal" };

            cb_PaymentMethod.ItemsSource = PaymentMethods;
		}

		private void cb_PaymentMethod_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
            bt_Pay.IsEnabled = cb_PaymentMethod_SelectionChanged != null;
		}
	}
}