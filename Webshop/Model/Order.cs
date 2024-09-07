using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.Model
{
    public class Order
    {
		public int OrderId { get; set; }
		
		public enum DelivStat {OrderPlaced, OnWay, Delivered, Anulled }

		public DelivStat DeliveryStatus { get; set; }
		
		public enum PayMethod {Card, Cash, MobilePay}
		
		public PayMethod PaymentMethod { get; set; }

		public bool Paid { get; set; }

		public string Email { get; set; }

		public ObservableCollection<Product> OrderProducts { get; set; }


		Order(int orderId, DelivStat deliveryStatus, PayMethod paymentMethod, bool paid, string email)
		{
			OrderId = orderId;
			DeliveryStatus = deliveryStatus;
			PaymentMethod = paymentMethod;
			Paid = paid;
			Email = email;
			OrderProducts = new ObservableCollection<Product>();
		}

		Order(int orderId, 
			DelivStat deliveryStatus, 
			PayMethod paymentMethod, 
			bool paid,
			string email,
			ObservableCollection<Product> orderProducts) : 
			this(orderId, deliveryStatus, paymentMethod, paid, email)
		{
			OrderProducts = orderProducts;
		}


		public int PK_OrderId()
		{
			throw new NotImplementedException();
		}


	}
}
