using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.Model
{
    class Order
    {
		private int orderId;

		public int OrderId
		{
			get { return orderId; }
			set { orderId = value; }
		}

		
		public enum delivStat {OrderPlaced, OnWay, Delivered }
		private string deliveryStatus;

		public string DeliveryStatus
		{
			get { return deliveryStatus; }
			set { deliveryStatus = value; }
		}


		public enum payMethod {Card, Cash, MobilePay}
		private string paymentMethod;

		public string PaymentMethod
		{
			get { return paymentMethod; }
			set { paymentMethod = value; }
		}

		private bool paid;

		public bool Paid
		{
			get { return paid; }
			set { paid = value; }
		}

		private string email;

		public string Email
		{
			get { return email; }
			set { email = value; }
		}

		private ObservableCollection<Product> orderProducts;

		public ObservableCollection<Product> OrderProducts
		{
			get { return orderProducts; }
			set { orderProducts = value; }
		}



		Order(int orderId, string deliveryStatus, string paymentMethod, bool paid, string email)
		{
			OrderId = orderId;
			DeliveryStatus = deliveryStatus;
			PaymentMethod = paymentMethod;
			Paid = paid;
			Email = email;
		}


		public int PK_OrderId()
		{
			throw new NotImplementedException();
		}


	}
}
