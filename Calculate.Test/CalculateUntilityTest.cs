using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculate.Test
{
    [TestClass]
    public class CalculateUtilityTest
    {
        [TestMethod]
        public void CalculateUtility_Calculate_Input0_Expect0()
        {
            //Arrange
            var expected = "0";

            //Act
            var actual = CalculateUtility.Calculate(0);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateUtility_Calculate_Input1_Expect1()
        {
            //Arrange
            var expected = "1";

            //Act
            var actual = CalculateUtility.Calculate(1);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateUtility_Calculate_Input2_Expect01()
        {
            //Arrange
            var expected = "01";

            //Act
            var actual = CalculateUtility.Calculate(2);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateUtility_Calculate_Input3_Expect011()
        {
            //Arrange
            var expected = "011";

            //Act
            var actual = CalculateUtility.Calculate(3);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}