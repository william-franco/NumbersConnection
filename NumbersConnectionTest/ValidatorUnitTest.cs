using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using NumbersConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersConnectionTest
{
    public class ValidatorUnitTest
    {
        private IValidator validator = new ValidatorImpl();

        [Fact]
        public void InputIsValidTest()
        {
            // Arrange
            int expectedValue = 10;
            string input = "10";

            // Act
            int amountReceived = validator.ValidateInput(input);

            // Assert 
            Assert.Equal(expectedValue, amountReceived);
        }

        [Fact]
        public void InputIsNumberPositiveTest() 
        {
            // Arrange
            string expectedValue = "Number must be positive.";
            string input = "-10";

            // Act
            Action act = () => validator.ValidateInput(input);

            ArgumentException exception = Assert.Throws<ArgumentException>(act);

            // Assert 
            Assert.Equal(expectedValue, exception.Message);
        }

        [Fact]
        public void InputIsStringTest() 
        {
            // Arrange
            string expectedValue = "Value must be a number.";
            string input = "lorem ipsum";

            // Act
            Action act = () => validator.ValidateInput(input);

            ArgumentException exception = Assert.Throws<ArgumentException>(act);

            // Assert 
            Assert.Equal(expectedValue, exception.Message);
        }
    }
}
