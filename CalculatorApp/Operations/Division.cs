using CalculatorApp.Interfaces;

namespace CalculatorApp.Operations
{
    public class Division : IDivision
    {
        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Dividing by 0!");
            }
            return a / b;
        }
    }
}