using System;
using ACM.BL;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            // Arrange
            Customer c1 = new Customer();
            c1.PrintName();
            Customer c2 = new Customer();
            c2.PrintName();
            Customer c3 = new Customer();
            c3.PrintName();
            int expected = 3;

            // Act
            int actual = Customer.CustomerCount;

            // Assert
            Assert.True(expected == actual);

        }

        [Fact]
        public void ValidateValid()
        {
            // Arrange
            Customer customer = new Customer
            {
                LastName = "PartyPants",
                Email = "howdydoody@google.com"
            };
            bool expected = true;

            // Act
            bool actual = customer.Validate();

            // Assert
            Assert.True(expected == actual);
        }

        [Fact]
        public void ValidateMissingLastName()
        {
            // Arrange
            Customer customer = new Customer
            {
                Email = "spongebob@squarepants.com",
                LastName = ""
            };
            bool expected = false;

            // Act
            bool actual = customer.Validate();


            // Assert
            Assert.True(expected == actual);
        }

        [Fact]
        public void ValidateMissingEmail()
        {
            // Arrange
            Customer squareCustomer = new Customer
            {
                LastName = "Squarepants"
            };
            bool expected = false;

            // Act
            bool actual = squareCustomer.Validate();

            // Assert
            Assert.True(expected == actual);
        }

        [Fact]
        public void ValidateEmailCharacters()
        {
            // Arrange
            Customer c1 = new Customer
            {
                LastName = "First",
                Email = "firstgoogle.com"
            };
            Customer c2 = new Customer
            {
                LastName = "Second",
                Email = "second@googlecom"
            };
            bool expected = false;

            // Act
            bool isValid = false;
            if (c1.Validate()) isValid = true;
            if (c2.Validate()) isValid = true;

            // Assert
            Assert.True(expected == isValid);
        }
    }
}
