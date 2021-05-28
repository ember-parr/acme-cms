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

        [Fact]
        public void TitleCaseTestValid()
        {
            // Arrange
            var source = "  sPoNgEboB sQUaRePanTz";
            var expected = "Spongebob Squarepantz";

            // Act
            var actual = StringHandler.TitleCase(source);

            // Assert
            Assert.True(expected == actual);
        }

        [Fact]
        public void LowerCaseTestValid()
        {
            // Arrange
            var source = "  HEllO FroM tHe oTHEr SiDe  ";
            var expected = "hello from the other side";

            // Act
            var actual = StringHandler.LowerCase(source);
            Console.WriteLine(actual);

            // Assert
            Assert.True(expected == actual);
        }

        [Fact]
        public void SentenceCaseTestValid()
        {
            // Arrange
            var source = "  ALL CAPS. all little. mIxEd.";
            var expected = "All caps. All little. Mixed.";

            // Act
            var actual = StringHandler.SentenceCase(source);
            Console.WriteLine(actual);

            // Assert
            Assert.True(expected == actual);
        }
    }
}
