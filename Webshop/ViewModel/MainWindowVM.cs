using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using Webshop.Model;

namespace Webshop.ViewModel
{
    internal class MainWindowViewModel : ViewModelBase
    {
        // listen med "items" til viewlaget
        public ObservableCollection<Customer> Customers {  get; set; }

        public MainWindowViewModel() 
        {
            //til test
            Customers = new ObservableCollection<Customer>();
            Customers.Add(new Customer
            {
                Name = "Sander",
                Email = "sander@gmail.com",
                PhoneNumber = "11223344",
                Address = "Hansensgade 1, 2400",
                Points = 350,
                CustomerOrders = new ObservableCollection<Order>()
            });

            Customers.Add(new Customer
            {
                Name = "Peter",
                Email = "peter@hotmail.com",
                PhoneNumber = "12345678",
                Address = "Lykkevej 24, 3650",
                Points = 0,
                CustomerOrders = new ObservableCollection<Order>()
            });
        }

        private string name;
        private string email;
        private string phonenumber;
        private string address;



        public void Register()
        {
            Customers.Add(new Customer(email, name, phonenumber, address));
        }

        public bool Login(string email)
        {

            if (Customers.Any(c => c.Email == email))
            { return true; }

            return false;

        }

        //public RelayCommand RegisterCommand => new RelayCommand(execute => Login(email));

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged();
            }
        }
        public string Phonenumber
        {
            get { return phonenumber; }
            set
            {
                phonenumber = value;
                OnPropertyChanged();
            }
        }
        public string Address
        {
            get { return address; }
            set
            {
                address = value;
                OnPropertyChanged();
            }
        }

        //den valgte "ting" i viewlaget


    }
}
