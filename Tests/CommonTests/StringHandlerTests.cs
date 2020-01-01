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
            StringHandler stringHandler = new StringHandler();

            // Act
            string stringResult = stringHandler.InsertSpaces(initialString);

            // Assert
            Assert.AreEqual(expectedString, stringResult);
        }

        [Test]
        public void InsertSpacesTestWithExistingSpaces()
        {
            // Arrange
            string initialString = "Sonic Screwdriver";
            string expectedString = "Sonic Screwdriver";
            StringHandler stringHandler = new StringHandler();

            // Act
            string stringResult = stringHandler.InsertSpaces(initialString);

            // Assert
            Assert.AreEqual(expectedString, stringResult);
        }
    }
}