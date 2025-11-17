using TestCalculator;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Addition()
        {
            var calculator = new Calculator(3, 4, "+");
            Assert.AreEqual(7, calculator.Function());
        }

        [Test]
        public void Subtraction()
        {
            var calculator = new Calculator(10, 5, "-");
            Assert.AreEqual(5, calculator.Function());
        }

        [Test]
        public void Multiplication()
        {
            var calculator = new Calculator(6, 7, "*");
            Assert.AreEqual(42, calculator.Function());
        }

        [Test]
        public void Division()
        {
            var calculator = new Calculator(20, 4, "/");
            Assert.AreEqual(5, calculator.Function());
        }

        [Test]
        public void DevByZer()
        {
            var calculator = new Calculator(10, 0, "/");
            Assert.Throws<DivideByZeroException>(() => calculator.Function());
        }

        [Test]
        public void NoOperation()
        {
            var calculator = new Calculator(5, 5, "%");
            Assert.Throws<NotImplementedException>(() => calculator.Function());
        }
        

        [Test]
        public void Bound()
        {
            double a = 1e150;
            double b = 1e150;

            var calculator = new Calculator(a, b, "+");
            Assert.AreEqual(2e150, calculator.Function());

            calculator = new Calculator(a, b, "*");
            Assert.IsTrue(double.IsInfinity(calculator.Function()) || !double.IsInfinity(calculator.Function()));
        }

        [Test]
        public void SmallBound()
        {
            double a = 1e-150;
            double b = 1e-150;

            var calculator = new Calculator(a, b, "+");
            Assert.That(calculator.Function(), Is.EqualTo(2e-150).Within(1e-160));

            calculator = new Calculator(a, b, "*");
            Assert.That(calculator.Function(), Is.EqualTo(1e-300).Within(1e-310));
        }

        [Test]
        public void FloatPoint()
        {
            var calculator = new Calculator(5.5, 2.2, "+");
            Assert.That(calculator.Function(), Is.EqualTo(7.7).Within(0.0001));

            calculator = new Calculator(5.5, 2.2, "*");
            Assert.That(calculator.Function(), Is.EqualTo(12.1).Within(0.0001));
        }
    }
}
