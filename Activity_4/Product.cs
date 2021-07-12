using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_4
{
    public class Product
    {
        public Cat category;
        public static int currentProductId;
        public string description;
        public double price;
        public string productId;
        public string productName;
        public Cat Cat { get; set; }
        public string Description { get; set; }
        public double Price {
            get {
                return price;
            } 
            set {
                price = value;
            } 
        }
        public string ProductId { get; set; }
        public string ProductName { get; set; }

        static Product()
        {}
        public Product()
        { }
        public Product(string productName, string description, double price, Cat category)
        {
            //Parameterised constructor
        }
    }
}
