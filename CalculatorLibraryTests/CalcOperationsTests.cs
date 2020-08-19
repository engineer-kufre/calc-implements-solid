using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary.Tests
{
    [TestClass()]
    public class CalcOperationsTests
    {
        [TestMethod()]
        public void AddTest()
        {
            //Arrange
            double num1 = 550;
            double num2 = 550;
            double expected = 1100;
            CalcOperations calc = new CalcOperations();

            //Act
            double actual = calc.Add(num1, num2);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DivideTest()
        {
            //Arrange
            double num1 = 550;
            double num2 = 2;
            double expected = 275;
            CalcOperations calc = new CalcOperations();

            //Act
            double actual = calc.Divide(num1, num2);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DivideByZeroTest()
        {
            //Arrange
            double num1 = 550;
            double num2 = 0;
            CalcOperations calc = new CalcOperations();

            //Act & Assert
            Assert.ThrowsException<DivideByZeroException>(() => calc.Divide(num1, num2));
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            //Arrange
            double num1 = 55;
            double num2 = 2.3;
            double expected = 126.49999999999999;
            CalcOperations calc = new CalcOperations();

            //Act
            double actual = calc.Multiply(num1, num2);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SubtractTest()
        {
            //Arrange
            double num1 = 550;
            double num2 = 2300;
            double expected = -1750;
            CalcOperations calc = new CalcOperations();

            //Act
            double actual = calc.Subtract(num1, num2);

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void EqualsAddTest()
        {
            //Arrange
            double num1 = 550;
            double num2 = 550;
            string operand = "+";
            double expected = 1100;
            CalcOperations calc = new CalcOperations();

            //Act
            double actual = calc.Equal(num1, operand, num2);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void EqualsSubtractTest()
        {
            //Arrange
            double num1 = 550;
            double num2 = 2300;
            double expected = -1750;
            string operand = "-";
            CalcOperations calc = new CalcOperations();

            //Act
            double actual = calc.Equal(num1, operand, num2);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void EqualsMultiplyTest()
        {
            //Arrange
            double num1 = 55;
            double num2 = 2.3;
            double expected = 126.49999999999999;
            string operand = "*";
            CalcOperations calc = new CalcOperations();

            //Act
            double actual = calc.Equal(num1, operand, num2);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void EqualsDivideTest()
        {
            //Arrange
            double num1 = 550;
            double num2 = 2;
            double expected = 275;
            string operand = "/";
            CalcOperations calc = new CalcOperations();

            //Act
            double actual = calc.Equal(num1, operand, num2);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}