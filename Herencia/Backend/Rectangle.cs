namespace GeometricFigures.Backend;

public class Rectangle : Square
{
    private readonly double _b;

    public Rectangle(string name, double a, double b) : base(name, a)
    {
        ValidateB(b);
        _b = b;
    }

    public double B => _b;

    public override double GetArea()
    {
        return A * B;
    }

    public override double GetPerimeter()
    {
        return 2 * (A + B);
    }

    private static void ValidateB(double b)
    {
        if (b <= 0)
            throw new ArgumentException("The side B must be greater than zero.");
    }
}
