namespace Module.Core;

/// <summary>
/// Калькулятор. Версия AI-v1.
/// </summary>
public class Calculator
{
    public double Add(double a, double b) => a + b;

    public double Subtract(double a, double b) => a - b;

    public double Multiply(double a, double b) => a * b;

    public double Divide(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException("Деление на ноль недопустимо.");
        return a / b;
    }

    public double Power(double baseValue, int exponent) => Math.Pow(baseValue, exponent);

    public double Sqrt(double value)
    {
        if (value < 0)
            throw new ArgumentException("Нельзя извлечь корень из отрицательного числа.", nameof(value));
        return Math.Sqrt(value);
    }

    public long Factorial(int n)
    {
        if (n < 0)
            throw new ArgumentException("Факториал определён только для n >= 0.", nameof(n));
        long result = 1;
        for (int i = 2; i <= n; i++)
            result = checked(result * i);
        return result;
    }

    public bool IsPrime(int n)
    {
        if (n < 2) return false;
        if (n % 2 == 0) return n == 2;
        for (int i = 3; (long)i * i <= n; i += 2)
            if (n % i == 0) return false;
        return true;
    }

    public double Average(params double[] values)
    {
        if (values == null || values.Length == 0)
            throw new ArgumentException("Нужно передать хотя бы одно число.", nameof(values));
        return values.Sum() / values.Length;
    }
}
