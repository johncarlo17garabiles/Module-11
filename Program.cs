using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class SaleApp
    {
        private string item;
        public string Item
        {
            get
            {
                return item;
            }
            set
            {
                item = value;
            }
        }
        private int quantity;

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }
        private string unit;
        public string Unit
        {
            get
            {
                return unit;
            }
            set
            {
                unit = value;
            }
        }
        private double price;
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        private double amount;
        public double Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
            }
        }
        static void Main(string[] args)
        {
            SaleApp item = new SaleApp();
            item.Item = "Cheesy Yum Burger";
            Console.WriteLine("Item: " + item.Item);

            SaleApp quantity = new SaleApp();
            quantity.Quantity = 10;
            Console.WriteLine("Quantity: " + quantity.Quantity);

            SaleApp unit = new SaleApp();
            unit.Unit = "jollibee";
            Console.WriteLine("Unit: " + unit.Unit);

            SaleApp price = new SaleApp();
            price.Price = 49.99;
            Console.WriteLine("Price: " + price.Price);

            SaleApp amount = new SaleApp();
            amount.Amount = (quantity.Quantity * price.Price);
            Console.WriteLine("Amount: " + amount.Amount);

        }
    }
}
