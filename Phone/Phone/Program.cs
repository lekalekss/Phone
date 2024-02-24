namespace Phone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone();

            phone.printPrice();
            Console.WriteLine("We have a phone with price " + "and color is " + phone.Color);



            Phone phone2 = new Phone("iOS", "SilverGrey", 1560, "iPhone");

            Console.WriteLine("\nWe are selling new phone");

            Console.WriteLine("Operation system is " + phone2.OperationSystem);

            Console.WriteLine("Color is " + phone2.Color);

            phone2.printPrice();

            Console.WriteLine("Brand is " + phone2.Brand);

            phone2.PhoneBoot();

            int newPrice = phone2.SetPhonePrice(2000);

            Console.WriteLine("New price is " + newPrice);

            int priceWithLocalTax = phone2.GetFullPrice();

            Console.WriteLine("Price with local tax is " + priceWithLocalTax);

            Phone sony = new Phone();
            sony.SetPhonePrice(1000);
            sony.SetProvinceTax("ON");
            int ontarioPrice = sony.GetFullPrice();


            Console.WriteLine("the price for the phone in Ontario is " + ontarioPrice);




        }
    }
}
