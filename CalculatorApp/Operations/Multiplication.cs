using CalculatorApp.Interfaces;

namespace CalculatorApp.Operations
{
    public class Multiplication : IMultiplication
    {
        public double Multiply(double a, double b)
        {
            return a * b;
        }
    }
}