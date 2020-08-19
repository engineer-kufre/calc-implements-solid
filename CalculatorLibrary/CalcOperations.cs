using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary
{
    //CalcOperations class fully implements ICalcOperations interface
    public class CalcOperations : ICalcOperations
    {
        //addition method implementation
        public double Add(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        //division method implementation
        public double Divide(double firstNumber, double secondNumber)
        {
            if (secondNumber == 0) //handle DivideByZeroException
            {
                throw new DivideByZeroException();
            }
            return firstNumber / secondNumber;
        }

        //equal method implementation
        public double Equal(double firstNumber, string calcOperator, double secondNumber)
        {
            double solution = 0;

            if (calcOperator == "+")
            {
                solution = Add(firstNumber, secondNumber);
            }
            else if (calcOperator == "-")
            {
                solution = Subtract(firstNumber, secondNumber);
            }
            else if (calcOperator == "*")
            {
                solution = Multiply(firstNumber, secondNumber);
            }
            else if (calcOperator == "/")
            {
                solution = Divide(firstNumber, secondNumber);
            }

            return solution;
        }

        //multiplication method implementation
        public double Multiply(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        //subtraction method implementation
        public double Subtract(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }
    }
}
