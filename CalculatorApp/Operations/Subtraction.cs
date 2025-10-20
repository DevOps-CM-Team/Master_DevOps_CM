using CalculatorApp.Interfaces;

namespace CalculatorApp.Operations
{
    public class Subtraction : ISubtraction
    {
        public double Subtract(double a, double b)
        {
            return a - b;
        }
    }
}