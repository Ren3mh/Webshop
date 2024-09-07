using System.Windows;
using Webshop.Model;
using Webshop.ViewModel;

namespace Webshop.View
{
	/// <summary>
	/// Interaction logic for CustomerView.xaml
	/// </summary>
	public partial class CustomerView : Window
	{
		CustomerWindowVM vm;

		public CustomerView(Customer customer)
		{
			InitializeComponent();
			vm = new CustomerWindowVM(customer);
			DataContext = vm;
		}
	}
}
