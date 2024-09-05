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

		private ObservableCollection<Order> customerOrders;

		public ObservableCollection<Order> CustomerOrders
		{
			get { return customerOrders; }
			set { customerOrders = value; }
		}



		Customer(string email, string name, string phonenumber, string address, int points)
		{
			Email = email;
			Name = name;
			PhoneNumber = phonenumber;	
			Address = address;
			Points = points;
			CustomerOrders = new ObservableCollection<Order>();
		}

		Customer(string email, string name, string phonenumber, string address, int points, ObservableCollection<Order>orders )
		{
			Email = email;
			Name = name;
			PhoneNumber = phonenumber;
			Address = address;
			Points = points;
			CustomerOrders = orders;
		}



		public string PK_Email()
		{
			throw new NotImplementedException();
		}





	}
}
