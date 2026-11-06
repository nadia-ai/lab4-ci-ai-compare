using Module.Core;
using NUnit.Framework;

namespace Module.Tests;

[TestFixture]
public class CalculatorTests
{
    private Calculator _calc = null!;

    [SetUp]
    public void SetUp()
    {
        // Перед каждым тестом создаётся новый экземпляр калькулятора
        _calc = new Calculator();
    }

    [TearDown]
    public void TearDown()
    {
        _calc = null!;
    }

    // ---------- Сложение и вычитание ----------

    [TestCase(2, 3, 5)]
    [TestCase(-4, 1.5, -2.5)]
    [TestCase(0, 0, 0)]
    public void Add_ReturnsSum(double a, double b, double expected)
    {
        Assert.AreEqual(expected, _calc.Add(a, b), 1e-9);
    }

    [TestCase(10, 4, 6)]
    [TestCase(3, 7, -4)]
    public void Subtract_ReturnsDifference(double a, double b, double expected)
    {
        Assert.AreEqual(expected, _calc.Subtract(a, b), 1e-9);
    }

    // ---------- Умножение и деление ----------

    [TestCase(6, 7, 42)]
    [TestCase(-2, 0.5, -1)]
    public void Multiply_ReturnsProduct(double a, double b, double expected)
    {
        Assert.AreEqual(expected, _calc.Multiply(a, b), 1e-9);
    }

    [Test]
    public void Divide_ReturnsQuotient()
    {
        Assert.AreEqual(2.5, _calc.Divide(5, 2), 1e-9);
    }

    [Test]
    public void Divide_ByZero_ThrowsDivideByZeroException()
    {
        Assert.Throws<DivideByZeroException>(() => _calc.Divide(1, 0));
    }

    // ---------- Степень и корень ----------

    [TestCase(2, 10, 1024)]
    [TestCase(5, 0, 1)]
    [TestCase(2, -2, 0.25)]
    public void Power_ReturnsCorrectValue(double b, int e, double expected)
    {
        Assert.AreEqual(expected, _calc.Power(b, e), 1e-9);
    }

    [Test]
    public void Sqrt_OfPositive_ReturnsRoot()
    {
        Assert.AreEqual(3.0, _calc.Sqrt(9), 1e-9);
    }

    [Test]
    public void Sqrt_OfNegative_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => _calc.Sqrt(-1));
    }

    // ---------- Факториал ----------

    [TestCase(0, 1)]
    [TestCase(1, 1)]
    [TestCase(5, 120)]
    [TestCase(20, 2432902008176640000)]
    public void Factorial_ReturnsCorrectValue(int n, long expected)
    {
        Assert.AreEqual(expected, _calc.Factorial(n));
    }

    [Test]
    public void Factorial_OfNegative_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => _calc.Factorial(-3));
    }

    [Test]
    public void Factorial_Overflow_ThrowsOverflowException()
    {
        Assert.Throws<OverflowException>(() => _calc.Factorial(21));
    }

    // ---------- Простые числа ----------

    [TestCase(2, true)]
    [TestCase(3, true)]
    [TestCase(17, true)]
    [TestCase(1, false)]
    [TestCase(4, false)]
    [TestCase(9, false)]
    [TestCase(-7, false)]
    public void IsPrime_ReturnsExpected(int n, bool expected)
    {
        Assert.AreEqual(expected, _calc.IsPrime(n));
    }

    // ---------- Среднее ----------

    [Test]
    public void Average_ReturnsMean()
    {
        Assert.AreEqual(2.5, _calc.Average(1, 2, 3, 4), 1e-9);
    }

    [Test]
    public void Average_OfEmpty_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => _calc.Average());
    }
}
