namespace Calculator.WebApi.Services
{
    public interface ICalculator
    {
        double Add(double n1, double n2);

        double Sub(double n1, double n2);

        double Divide(double n1, double n2);

        double Multiply(double n1, double n2);
    }
}