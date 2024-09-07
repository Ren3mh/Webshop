using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Webshop.Model;

namespace Webshop.ViewModel
{
    internal class LoginCommand : ICommand
    {
        private MainWindowViewModel _viewModel;

        public LoginCommand(MainWindowViewModel vm)
        {
            _viewModel = vm;
        }


        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            bool success = CheckIfCustomerExists(_viewModel.LoginEmail, _viewModel.Customers);
        }

        private bool CheckIfCustomerExists(string email, ObservableCollection<Customer> customers)
        {
            if (customers.Any(c => c.Email == email))
                return false;

            return true;
        }
    }
}
