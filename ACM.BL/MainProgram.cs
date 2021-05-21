using System;
namespace ACM.BL
{
    public class MainProgram
    {
        static void Ember(string[] args)
        {
            Console.WriteLine("Customer Count: " + Customer.CustomerCount);
            Console.WriteLine("----------");

            var ember = new Customer
            {
                FirstName = "Ember",
                LastName = "Parr"
            };

            ember.PrintName();

            Console.WriteLine("----------");
            Console.WriteLine("Customer Count: " + Customer.CustomerCount);

            var justin = new Customer
            {
                FirstName = "Justin",
                LastName = "Adams"
            };
            justin.PrintName();
            Console.WriteLine("Customer Count: " + Customer.CustomerCount);
            Console.WriteLine("----------");

            var biggie = new Customer
            {
                FirstName = "Biggie"
            };
            biggie.PrintName();
            Console.WriteLine("Customer Count: " + Customer.CustomerCount);
            Console.WriteLine("----------");

            var snoop = new Customer
            {
                LastName = "Snoop"
            };
            snoop.PrintName();
            Console.WriteLine("Customer Count: " + Customer.CustomerCount);
            Console.WriteLine("----------");


            Console.Read();
        }
    }
}
