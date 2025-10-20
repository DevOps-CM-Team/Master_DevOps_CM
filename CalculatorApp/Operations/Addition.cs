using CalculatorApp.Interfaces;

namespace CalculatorApp.Operations
{
    public class Addition : IAddition
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
    }
}