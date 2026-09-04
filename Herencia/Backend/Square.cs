namespace GeometricFigures.Backend;

public class Square : GeometricFigure
{
    private readonly double _a;

    public Square(string name, double a) : base(name)
    {
        ValidateA(a);
        _a = a;
    }

    public double A => _a;

    public override double GetArea()
    {
        return Math.Pow(A, 2);
    }

    public override double GetPerimeter()
    {
        return 4 * A;
    }

    private static void ValidateA(double a)
    {
        if (a <= 0)
            throw new ArgumentException("The side must be greater than zero.");
    }
}