namespace TestCalculator;

public class Calculator
{
    public double A { get; }
    public double B { get; }
    public string ToDo { get; }

    public Calculator(double x, double y, string Do){
        A = x;
        B = y;
        ToDo = Do;
    }
    
    public double Function()
    {
        return ToDo switch
        {
            "+" => A + B,
            "-" => A - B,
            "*" => A * B,
            "/" => B != 0 ? A / B : throw new DivideByZeroException("Cant divide by zero"),
            _ => throw new NotImplementedException("No operation available")
        };
    }
}