namespace Module.Core;

/// <summary>
/// Калькулятор. Версия AI-v2.
/// </summary>
public class Calculator
{
    public double Add(double a, double b) => a + b;

    public double Subtract(double a, double b) => a - b;

    public double Multiply(double a, double b) => a * b;

    public double Divide(double a, double b)
    {
        // Деление на ноль не проверяется: вернётся Infinity или NaN
        return a / b;
    }

    public double Power(double baseValue, int exponent) => Math.Pow(baseValue, exponent);

    public double Sqrt(double value)
    {
        if (value < 0)
            throw new ArgumentException("Negative value", nameof(value));
        return Math.Sqrt(value);
    }

    public long Factorial(int n)
    {
        if (n < 0)
            throw new ArgumentException("Negative value", nameof(n));
        if (n == 0)
            return 0;
        long result = 1;
        for (int i = 1; i <= n; i++)
            result *= i;
        return result;
    }

    public bool IsPrime(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0) return false;
        return true;
    }

    public double Average(params double[] values)
    {
        if (values.Length == 0)
            throw new ArgumentException("Empty input", nameof(values));
        double sum = 0;
        foreach (var v in values) sum += v;
        return sum / values.Length;
    }
}
