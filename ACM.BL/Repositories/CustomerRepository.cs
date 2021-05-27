using System;
using System.Linq;
namespace ACM.BL.Repositories
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        private AddressRepository addressRepository { get; set; }


        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);


            // HARD CODED CUSTOMER DATA
            // Not creating Data Access   Layer for this project
            if (customer.CustomerId == 1)
            {
                customer.Email = "Foo@bar.org";
                customer.FirstName = "Foo";
                customer.LastName = "Bar";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }
            Console.WriteLine($"Customer: {customer.ToString()}");
            return customer;
        }

        public bool Save(Customer customer)
        {
            var success = true;
            if (customer.HasChanges)
            {
                if (customer.IsValid)
                {
                    if (customer.IsNew)
                    {
                        // CALL AN INSERT STORED PROCEDURE
                    }
                    else
                    {
                        // CALL AN UPDATE STORED PROCEDURE
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
