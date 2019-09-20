using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwesomeCalculator;
using NUnit.Framework;

namespace CalculatorTest
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void GetAddition_Input3and5Returns8()
        {
            //Arrange
            double number1 = 3;
            double number2 = 5;
            double expectedResult = number1 + number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetAddition();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetAddition_Input4and6Returns10()
        {
            //Arrange
            double number1 = 4;
            double number2 = 6;
            double expectedResult = number1 + number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetAddition();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetAddition_Input8and9Returns17()
        {
            //Arrange
            double number1 = 8;
            double number2 = 9;
            double expectedResult = number1 + number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetAddition();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }[Test]
        public void GetSubtraction_Input8and6Returns2()
        {
            //Arrange
            double number1 = 8;
            double number2 = 6;
            double expectedResult = number1 - number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetSubtraction();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }[Test]
        public void GetSubtraction_Input9and3Returns6()
        {
            //Arrange
            double number1 = 9;
            double number2 = 3;
            double expectedResult = number1 - number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetSubtraction();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }[Test]
        public void GetSubtraction_Input10and6Returns4()
        {
            //Arrange
            double number1 = 10;
            double number2 = 6;
            double expectedResult = number1 - number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetSubtraction();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }[Test]
        public void GetMultiplication_Input9and3Returns27()
        {
            //Arrange
            double number1 = 9;
            double number2 = 3;
            double expectedResult = number1 * number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetMultiplication();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }[Test]
        public void GetMultiplication_Input10and3Returns30()
        {
            //Arrange
            double number1 = 10;
            double number2 = 3;
            double expectedResult = number1 * number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetMultiplication();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }[Test]
        public void GetMultiplication_Input6and3Returns18()
        {
            //Arrange
            double number1 = 6;
            double number2 = 3;
            double expectedResult = number1 * number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetMultiplication();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }[Test]
        public void GetDivision_Input9and3Returns3()
        {
            //Arrange
            double number1 = 9;
            double number2 = 3;
            double expectedResult = number1 / number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetDivision();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }[Test]
        public void GetDivision_Input4and2Returns2()
        {
            //Arrange
            double number1 = 4;
            double number2 = 2;
            double expectedResult = number1 / number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetDivision();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }[Test]
        public void GetDivision_Input6and2Returns3()
        {
            //Arrange
            double number1 = 6;
            double number2 = 2;
            double expectedResult = number1 / number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetDivision();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
