using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.Model
{
    public class Customer
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
		{ }

		public Customer(string email, string name, string phonenumber, string address)
		{
            Email = email;
            Name = name;
            PhoneNumber = phonenumber;
            Address = address;
            Points = 100; //starting points
            CustomerOrders = new ObservableCollection<Order>();
        }

		public Customer(
			string email, 
			string name, 
			string phonenumber, 
			string address, int points, 
			ObservableCollection<Order> customerOrders) : 
			this(email, name, phonenumber, address)
		{
			Points = points;
			CustomerOrders = customerOrders;
		}

		public string PK_Email()
		{
			throw new NotImplementedException();
		}





	}
}
