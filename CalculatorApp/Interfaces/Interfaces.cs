namespace CalculatorApp.Interfaces
{
    public interface IAddition
    {
        double Add(double a, double b);
    }

    public interface ISubtraction
    {
        double Subtract(double a, double b);
    }

    public interface IMultiplication
    {
        double Multiply(double a, double b);
    }

    public interface IDivision
    {
        double Divide(double a, double b);
    }
}