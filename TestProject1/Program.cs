using TestCalculator;

try
{
    Calculator calculator = new Calculator(1, 1, "+");
    Console.WriteLine(calculator.Function());

    calculator = new Calculator(2, 3, "-");
    Console.WriteLine(calculator.Function());

    calculator = new Calculator(6, 7, "*");
    Console.WriteLine(calculator.Function());

    calculator = new Calculator(34, 23, "/");
    Console.WriteLine(calculator.Function());

    calculator = new Calculator(1, 0, "/");
    Console.WriteLine(calculator.Function());
}
catch (Exception DevByZer)
{
    Console.WriteLine($"ERROR: {DevByZer.Message}");
}