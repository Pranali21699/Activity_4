using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_4
{
    public class Purchase
    {
        public Cust customer;
        public DateTime dateOfPurchase;
        public string paymentType;
        public static int purchaseCounter;
        public string purchaseId;
        public int quantityOrdered;
        public string shippingAddress;
        public Cust Customer { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public string PaymentType { get; set; }
        public string PurchaseId { get; set; }
        public int QuantityOrdered { get; set; }
        public string ShippingAddress { get; set; }

        static Purchase()
        { }
        public Purchase()
        { }
        public Purchase(Cust customer, int quantityOrdered, string shippingAddress, DateTime dateOfPurchase, string paymentType)
        {

        }

        public double CalculateDiscount()
        {
            return 0.05;
        }
        public double CalculateBillAmount(params Product[] products)
        {
            double totalPrice = 0.0;
            foreach (Product price in products)
            {
                totalPrice += Convert.ToDouble(price);
            }

            double serviceTax = 0.07 * totalPrice;
            double discountPercentage = CalculateDiscount();
            double totalBillAmount = ((totalPrice + serviceTax) * (1 - discountPercentage));
            return totalBillAmount;
        }
        public double CalculateBillAmount(Product product, int quantityRequired)
        {
            double totalPrice = product.Price * quantityRequired;
            double serviceTax = 0.07 * totalPrice;
            double discountPercentage = CalculateDiscount();
            double totalBillAmount = ((totalPrice + serviceTax) * (1 - discountPercentage));
            return totalBillAmount;

        }
    }
}
