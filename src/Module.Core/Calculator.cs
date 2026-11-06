namespace Module.Core;

/// <summary>
/// Калькулятор. Версия AI-v3.
/// </summary>
public class Calculator
{
    public double Add(double a, double b) => a + b;

    public double Subtract(double a, double b) => b - a;

    public double Multiply(double a, double b) => a * b;

    public double Divide(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException();
        return a / b;
    }

    public double Power(double baseValue, int exponent)
    {
        double result = 1;
        for (int i = 0; i < exponent; i++)
            result *= baseValue;
        return result;
    }

    public double Sqrt(double value) => Math.Sqrt(value);

    public long Factorial(int n)
    {
        if (n < 0)
            throw new ArgumentException("n < 0", nameof(n));
        long result = 1;
        for (int i = 2; i <= n; i++)
            result *= i;
        return result;
    }

    public bool IsPrime(int n)
    {
        if (n <= 1) return false;
        for (int i = 2; i < n / 2; i++)
            if (n % i == 0) return false;
        return true;
    }

    public double Average(params double[] values)
    {
        if (values.Length == 0)
            return 0;
        return values.Sum() / values.Length;
    }
}
