using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.Model
{

    public enum Category { creme, pulver };

    public class Product
    {
		public int ProductId { get; set; }
		
		public Category _Category;

		public string Name { get; set; }

		public string Description { get; set; }

		public double Price { get; set; }

		public int Stock { get; set; }

		public string ImagePath { get; set; }

		Product(int productId, int category, string name, string description, double price, int stock, string imagePath)
		{
			ProductId = productId;
			_Category = Category.creme;
			Name = name;
			Description = description;
			Price = price;
			Stock = stock;
			ImagePath = imagePath;
		}

		public Product() { }

		public int PK_productId()
		{
			throw new NotImplementedException();
		}



	}
}
