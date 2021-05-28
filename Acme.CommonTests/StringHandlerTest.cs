using System;
using Acme.Common;
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

            // Act
            var actual = source.InsertSpaces();
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

            // Act
            var actual = source.InsertSpaces();

            // Assert
            Assert.True(expected == actual);
        }

        [Fact]
        public void InsertSpacesTestEmptyString()
        {
            // Arrange
            var source = "   ";
            var expected = String.Empty;

            // Act
            var actual = source.InsertSpaces();

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
            var actual = source.TitleCase();

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
            var actual = source.LowerCase();
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
            var actual = source.SentenceCase();
            Console.WriteLine(actual);

            // Assert
            Assert.True(expected == actual);
        }
    }
}
