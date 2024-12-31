using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProductID
{
    internal class Product
    {
        public string ProductId {  get; set; }
        public string ProductName { get; set; }
        public double Quantity {  get; set; }
        public double Price { get; set; }
         
        public Product(string productId, string productName, double quantity, double price) 
        {
            ProductId = productId;  
            ProductName = productName;
            Quantity = quantity;
            Price = price;
        }

        public virtual void DisplayProduct()
        {
            Console.WriteLine($"ID: {ProductId}, Name: {ProductName}, Price: {Price}, Quantity: {Quantity}");
        }
    }
}
