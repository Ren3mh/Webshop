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

		
		public enum delivStat {OrderPlaced, OnWay, Delivered, Anulled }
		private int deliveryStatus;

		public int DeliveryStatus
		{
			get { return deliveryStatus; }
			set { deliveryStatus = value; }
		}


		public enum payMethod {Card, Cash, MobilePay}
		private int paymentMethod;

		public int PaymentMethod
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



		Order(int orderId, int deliveryStatus, int paymentMethod, bool paid, string email)
		{
			OrderId = orderId;
			DeliveryStatus = deliveryStatus;
			PaymentMethod = paymentMethod;
			Paid = paid;
			Email = email;
			OrderProducts = new ObservableCollection<Product>();
		}

		Order(int orderId, int deliveryStatus, int paymentMethod, bool paid, string email, ObservableCollection<Product> orderProducts)
		{
			OrderId = orderId;
			DeliveryStatus = deliveryStatus;
			PaymentMethod = paymentMethod;
			Paid = paid;
			Email = email;
			OrderProducts = orderProducts;
		}


		public int PK_OrderId()
		{
			throw new NotImplementedException();
		}


	}
}
