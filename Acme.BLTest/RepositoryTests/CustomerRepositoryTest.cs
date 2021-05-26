using System;
using Xunit;
using ACM.BL;
using ACM.BL.Repositories;
using System.Collections.Generic;

namespace Acme.BLTest.RepositoryTests
{
    public class CustomerRepositoryTest
    {
        [Fact]
        public void RetrieveValid()
        {
            // Arrange
            var repo = new CustomerRepository();
            var expected = new Customer(1)
            {
                Email = "Foo@bar.org",
                FirstName = "Foo",
                LastName = "Bar"
            };

            // Act
            var actual = repo.Retrieve(1);

            // Assert
            Assert.True(expected.FirstName == actual.FirstName);
            Assert.True(expected.LastName == actual.LastName);
            Assert.True(expected.Email == actual.Email);
            Assert.True(expected.CustomerId == actual.CustomerId);
        }

        [Fact]
        public void RetrieveExistingWithAddress()
        {
            // Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                Email = "Foo@bar.org",
                FirstName = "Foo",
                LastName = "Bar",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        AddressLine1 = "123 Main St.",
                        AddressLine2 = "apt 3",
                        City = "Nashville",
                        State = "TN",
                        Country = "United States",
                        PostalCode = "37064"
                    },
                    new Address()
                    {
                        AddressType = 2,
                        AddressLine1 = "Green Dragon",
                        City = "Bywater",
                        State = "Shire",
                        Country = "Middle Earth",
                        PostalCode = "146"
                    }
                }
            };

            // Act
            var actual = customerRepository.Retrieve(1);

            // Assert
            Assert.True(expected.CustomerId == actual.CustomerId);
            Assert.True(expected.Email == actual.Email);
            Assert.True(expected.FirstName == actual.FirstName);
            Assert.True(expected.LastName == actual.LastName);
            for ( int i = 0; i <1; i++ )
            {
                Assert.True(expected.AddressList[i].AddressType == actual.AddressList[i].AddressType);
                Assert.True(expected.AddressList[i].AddressLine1 == actual.AddressList[i].AddressLine1);
                Assert.True(expected.AddressList[i].City == actual.AddressList[i].City);
                Assert.True(expected.AddressList[i].State == actual.AddressList[i].State);
                Assert.True(expected.AddressList[i].Country == actual.AddressList[i].Country);
                Assert.True(expected.AddressList[i].PostalCode == actual.AddressList[i].PostalCode);
            }
        }
    }
}
