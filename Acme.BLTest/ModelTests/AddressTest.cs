using System;
using Xunit;
using ACM.BL;

namespace Acme.BLTest
{
    public class AddressTest
    {
        [Fact]
        public void ValidatorValid()
        {
            // Arrange
            Address home = new Address
            {
                PostalCode = "37174",
                AddressLine1 = "123 Drerry Way"
            };
            bool expected = true;

            // Act
            bool actual = home.Validate();

            // Assert
            Assert.True(expected == actual);
        }

        [Fact]
        public void ValidateMissingPostal()
        {
            // Arrange
            Address work = new Address
            {
                AddressLine1 = "361 Main St.",
                City = "Gotham",
                State = "AK"
            };
            bool expected = false;

            // Act
            bool actual = work.Validate();

            // Assert
            Assert.True(expected == actual);
        }


        [Fact]
        public void ValidateMissingLineOne()
        {
            // Arrange
            Address work = new Address
            {
                PostalCode = "8675309",
                City = "Gotham",
                State = "AK"
            };
            bool expected = false;

            // Act
            bool actual = work.Validate();

            // Assert
            Assert.True(expected == actual);
        }
    }
}
