namespace GeometricFigures.Backend;

public class Trapeze : Triangle
{
    private readonly double _d;

    public Trapeze(
        string name,
        double a,
        double b,
        double c,
        double d,
        double h) : base(name, a, b, c, h)
    {
        ValidateD(d);
        _d = d;
    }

    public double D => _d;

    public override double GetArea()
    {
        return ((B + D) * H) / 2;
    }

    public override double GetPerimeter()
    {
        return A + B + C + D;
    }

    private static void ValidateD(double d)
    {
        if (d <= 0)
            throw new ArgumentException("D must be greater than zero.");
    }
}