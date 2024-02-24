using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    public class Phone
    {
        public Phone() 
        {
            
            Color = "black";
            Price = 100;
                    
        }

        public Phone(string operationSystem, string color, int price, string brand)
        {
            OperationSystem = operationSystem;

            Color = color;

            Price = price;

            Brand = brand;
        
        }

        public string OperationSystem { get; set; }

        public string Color { get; set; }

        private int Price { get; set; }

        public string Brand { get; set; }

        

        public void printPrice () 
        {
            Console.WriteLine("The price is " + Price);
        }

        public int localTax { get; set; } = 13;
        

        
        public void PhoneBoot ()
        {
            Console.WriteLine(OperationSystem +" " + Color+" " + Price+" " + Brand);
        }

        public int GetFullPrice ()
        {            
            int fullLocalPrice = Price * localTax / 100 + Price;
            
            return fullLocalPrice;
        }

        public int SetPhonePrice(int newPrice)
        {
            Price = newPrice;
            return Price;
        }

        public void SetProvinceTax (string province)

        {
            switch (province)
            {
                case "MB":
                    localTax = 13;
                    break;

                case "ON":
                    localTax = 12;
                    break;
                case "SK":
                    localTax = 10;
                    break;
                case "AB":
                    localTax = 8;
                    break;
                case "BC":
                    localTax = 11;
                    break;

                default:
                    Console.WriteLine("Enter correct province");
                    break;

            }          

        }

    }
    
}
