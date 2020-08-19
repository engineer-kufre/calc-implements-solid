using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary
{
    //interface for all calculator operations
    public interface ICalcOperations
    {
        double Add(double firstNumber, double secondNumber);
        double Subtract(double firstNumber, double secondNumber);
        double Multiply(double firstNumber, double secondNumber);
        double Divide(double firstNumber, double secondNumber);
        double Equal(double firstNumber, string calcOperator, double secondNumber);
    }
}
