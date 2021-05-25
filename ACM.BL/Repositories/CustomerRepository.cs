using System;
namespace ACM.BL.Repositories
{
    public class CustomerRepository
    {
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
            }
            return customer;
        }

        public bool Save(Customer customer)
        {
            // Hard coded data because of no Data Access Layer in this project
            // will return true rather than a customer. 
            return true;
        }
    }
}
