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
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            string expected = "Baggins, Bilbo";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.True(expected == actual);

        }

        [Fact]
        public void FullNameLastEmpty()
        {
            // Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo"
            };
            string expected = "Bilbo";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.True(expected == actual);

        }

        [Fact]
        public void FullNameFirstEmpty()
        {
            // Arrange
            Customer customer = new Customer
            {
                LastName = "Baggins"
            };
            string expected = "Baggins";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.True(expected == actual);

        }

        [Fact]
        public void CustomerCountCheck()
        {
            Customer c1 = new Customer();
            c1.PrintName();
            Customer c2 = new Customer();
            c2.PrintName();
            Customer c3 = new Customer();
            c3.PrintName();
            int expected = 3;

            int actual = Customer.CustomerCount;

            Assert.True(expected == actual);

        }

        [Fact]
        public void CheckValidate()
        {
            Customer customer = new Customer
            {
                LastName = "PartyPants",
                Email = "howdydoody@google.com"
            };
            bool expected = true;

            bool actual = customer.Validate();

            Assert.True(expected == actual);
        }
    }
}
