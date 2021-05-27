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
    }
}
