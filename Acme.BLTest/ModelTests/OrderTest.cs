using System;
using ACM.BL;
using Xunit;
namespace Acme.BLTest
{
    public class OrderTest
    {
        [Fact]
        public void ValidateValid()
        {
            // Arrange
            Order order = new Order
            {
                OrderDate = DateTime.Now
            };
            bool expected = true;

            // Act
            bool actual = order.Validate();

            // Assert
            Assert.True(expected == actual);
        }

        [Fact]
        public void ValidateMissingDate()
        {
            // Arrange
            Order order = new Order
            {
                OrderDate = null
            };
            bool expected = false;

            // Act
            bool actual = order.Validate();

            // Assert
            Assert.True(expected == actual);
        }
    }
}
