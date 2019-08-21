using NUnit.Framework;

namespace Simple.Calculator.UnitTests
{
    public class CalculatorShould
    {
        [Test]
        public void Test1()
        {
            var calculator = new Calculator();
            var actual = calculator.Add(1, 1);
            Assert.AreEqual(2, actual);
        }
    }
}