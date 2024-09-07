using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.Model
{
    class Product
    {
		public int ProductId { get; set; }


		public enum Category {creme, pulver};
		public Category Test;
		

		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private string description;

		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		private double price;

		public double Price
		{
			get { return price; }
			set { price = value; }
		}

		private int stock;

		public int Stock
		{
			get { return stock; }
			set { stock = value; }
		}

		private string imagePath;

		public string ImagePath
		{
			get { return imagePath; }
			set { imagePath = value; }
		}

		Product(int productId, int category, string name, string description, double price, int stock, string imagePath)
		{
			ProductId = productId;
			test = 0; //category enum problemer
			Name = name;
			Description = description;
			Price = price;
			Stock = stock;
			ImagePath = imagePath;
		}

		public int PK_productId()
		{
			throw new NotImplementedException();
		}



	}
}
