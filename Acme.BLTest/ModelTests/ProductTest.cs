using System;
using System.Security.Cryptography.X509Certificates;
using ACM.BL;
using Xunit;
namespace Acme.BLTest
{
    public class ProductTest
    {
        [Fact]
        public void ValidateValid()
        {
            // Arrange
            Product product = new Product
            {
                CurrentPrice = 14,
                ProductName = "Banana Milk"
            };
            bool expected = true;

            // Act
            bool actual = product.Validate();

            // Assert
            Assert.True(expected == actual);
        }

        [Fact]
        public void ValidateMissingName()
        {
            // Arrange
            Product mystery = new Product
            {
                CurrentPrice = 30
            };
            bool expected = false;

            // Act
            bool actual = mystery.Validate();

            // Assert
            Assert.True(expected == actual);
        }

        [Fact]
        public void ValidateMissingPrice()
        {
            // Arrange
            Product freebie = new Product
            {
                ProductName = "freebie!"
            };
            bool expected = false;

            // Act
            bool actual = freebie.Validate();

            // Assert
            Assert.True(expected == actual);
        }

        [Fact]
        public void ProductNameFormatting()
        {
            // Arrange
            Product noSpaces = new Product
            {
                ProductName = "ChocolateBath",
                CurrentPrice = 15M
            };
            Product lowerCase = new Product
            {
                ProductName = "chocolate bath",
                CurrentPrice = 15M
            };
            Product allCaps = new Product
            {
                ProductName = "CHOCOLATE BATH",
                CurrentPrice = 15M
            };
            Product inverseCase = new Product
            {
                ProductName = "cHOCOLATE bATH",
                CurrentPrice = 15M
            };
            Product correctName = new Product
            {
                ProductName = "Chocolate Bath",
                CurrentPrice = 15M
            };
            string expected = "Chocolate Bath";

            // Act
            var actual1 = noSpaces.ProductName;
            var actual2 = lowerCase.ProductName;
            var actual3 = allCaps.ProductName;
            var actual4 = inverseCase.ProductName;
            var actual5 = correctName.ProductName;

            // Assert
            Assert.True(expected == actual1);
            Assert.True(expected == actual2);
            Assert.True(expected == actual3);
            Assert.True(expected == actual4);
            Assert.True(expected == actual5);
        }

    }
}
