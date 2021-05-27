using System;
using Xunit;
using ACM.BL;
using ACM.BL.Repositories;

namespace Acme.BLTest.RepositoryTests
{
    public class OrderRepositoryTest
    {
        [Fact]
        public void RetrieveValid()
        {
            // Arrange
            var repo = new OrderRepository();
            var expected = new Order(10)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0))
            };

            // Act
            var actual = repo.Retrieve(10);

            // Assert
            Assert.True(expected.OrderDate == actual.OrderDate);
        }


        [Fact]
        public void SaveTestValid()
        {
            // Arrange
            var orderRepo = new OrderRepository();
            var updatedOrder = new Order(18)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0)),
                HasChanges = true
            };

            // Act
            var actual = orderRepo.Save(updatedOrder);

            // Assert
            Assert.True(actual);
        }

        [Fact]
        public void SaveTestMissingOrderDate()
        {
            // Arrange
            var orderRepo = new OrderRepository();
            var updatedOrder = new Order(24)
            {
                HasChanges = true
            };

            // Act
            var actual = orderRepo.Save(updatedOrder);

            // Assert
            Assert.False(actual);
        }
    }
}
