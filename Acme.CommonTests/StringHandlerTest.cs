using System;
using Acme.Common.Methods;
using Xunit;

namespace Acme.CommonTests
{
    public class StringHandlerTest
    {
        [Fact]
        public void InsertSpacesTestValid()
        {
            // Arrange
            var source = "MarioBrothers";
            var expected = "Mario Brothers";
            var handler = new StringHandler();

            // Act
            var actual = handler.InsertSpaces(source);
            Console.WriteLine($"Source: {source}");
            Console.WriteLine($"Expected: {expected}");
            Console.WriteLine($"Actual: {actual}");

            // Assert
            Assert.True(expected == actual);
        }

        [Fact]
        public void InsertSpacesTestWithExistingSpace()
        {
            // Arrange
            var source = "Crazy Cat Lady";
            var expected = "Crazy Cat Lady";
            var handler = new StringHandler();

            // Act
            var actual = handler.InsertSpaces(source);

            // Assert
            Assert.True(expected == actual);
        }

        [Fact]
        public void InsertSpacesTestEmptyString()
        {
            // Arrange
            var source = "   ";
            var expected = String.Empty;
            var handler = new StringHandler();

            // Act
            var actual = handler.InsertSpaces(source);

            // Assert
            Assert.True(expected == actual);
        }
    }
}
