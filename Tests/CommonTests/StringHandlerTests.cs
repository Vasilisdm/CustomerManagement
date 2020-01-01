using Common;
using NUnit.Framework;

namespace CommonTests
{
    public class StringHandlerTests
    {
        [Test]
        public void InsertSpacesTestValid()
        {
            // Arrange
            string initialString = "SonicScrewdriver";
            string expectedString = "Sonic Screwdriver";

            // Act
            string stringResult = initialString.InsertSpaces();

            // Assert
            Assert.AreEqual(expectedString, stringResult);
        }

        [Test]
        public void InsertSpacesTestWithExistingSpaces()
        {
            // Arrange
            string initialString = "Sonic Screwdriver";
            string expectedString = "Sonic Screwdriver";

            // Act
            string stringResult = initialString.InsertSpaces();

            // Assert
            Assert.AreEqual(expectedString, stringResult);
        }
    }
}