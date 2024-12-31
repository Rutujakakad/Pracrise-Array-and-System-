using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductID
{
    internal class Inventory
    {
        public List<Product> Products { get; set; }
        public Inventory()
        {
            Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
            Console.WriteLine($"Product {product.ProductName} added  to Inventory");
        }

    }
}
