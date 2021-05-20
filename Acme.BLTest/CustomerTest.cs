using System;
using ACM.BL;
using Xunit;

namespace Acme.BLTest
{
    public class CustomerTest
    {
        [Fact]
        public void FullNameTestValid()
        {
            // Arrange
            Customer customer = new Customer();
            customer.FirstName = "Transformers";
            customer.LastName = "Activate";

            // Act

            // Assert

        }
    }
}
