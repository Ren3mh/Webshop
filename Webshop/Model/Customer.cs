using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.Model
{
    class Customer
    {

		// hvorfor ikke bare public string Email { get; set; } ?
		private string email;

		public string Email
		{
			get { return email; }
			set { email = value; }
		}

		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private string phoneNumber;

		public string PhoneNumber
		{
			get { return phoneNumber; }
			set { phoneNumber = value; }
		}

		private string address;

		public string Address
		{
			get { return address; }
			set { address = value; }
		}

		private int points;

		public int Points
		{
			get { return points; }
			set { points = value; }
		}

		// hvorfor ObservableCollection ?
		private ObservableCollection<Order> customerOrders;

		public ObservableCollection<Order> CustomerOrders
		{
			get { return customerOrders; }
			set { customerOrders = value; }
		}

		public Customer()
		{
			Email = string.Empty;
			Name = string.Empty;
			PhoneNumber = string.Empty;
			Address = string.Empty;
			Points = 0;
            CustomerOrders = new ObservableCollection<Order>();
        }

		public Customer(string email, string name, string phonenumber, string address, int points) : this()
		{
			Email = email;
			Name = name;
			PhoneNumber = phonenumber;	
			Address = address;
			Points = points;
		}

		public string PK_Email()
		{
			throw new NotImplementedException();
		}





	}
}
