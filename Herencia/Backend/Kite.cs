namespace GeometricFigures.Backend;

public class Kite : Rhombus
{
    private readonly double _b;

    public Kite(
        string name,
        double a,
        double b,
        double d1,
        double d2) : base(name, a, d1, d2)
    {
        ValidateB(b);
        _b = b;
    }

    public double B => _b;

    public override double GetArea()
    {
        return (D1 * D2) / 2;
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