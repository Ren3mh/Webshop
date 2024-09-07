using Webshop.Model;

namespace Webshop.ViewModel
{
    internal class CustomerWindowVM : ViewModelBase
    {

        private Customer _customer;

        public CustomerWindowVM(Customer customer) 
        { 
            _customer = customer;
        }
    
        public Customer Customer 
        { 
            get { return _customer; } 
            set 
            {
                _customer = value;
                OnPropertyChanged();
            }
        }
    }
}
