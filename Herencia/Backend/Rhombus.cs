namespace GeometricFigures.Backend;

public class Rhombus : Square
{
    private readonly double _d1;
    private readonly double _d2;

    public Rhombus(string name, double a, double d1, double d2)
        : base(name, a)
    {
        ValidateD1(d1);
        ValidateD2(d2);

        _d1 = d1;
        _d2 = d2;
    }

    public double D1 => _d1;

    public double D2 => _d2;

    public override double GetArea()
    {
        return (D1 * D2) / 2;
    }

    public override double GetPerimeter()
    {
        return 4 * A;
    }

    private static void ValidateD1(double d1)
    {
        if (d1 <= 0)
            throw new ArgumentException("D1 must be greater than zero.");
    }

    private static void ValidateD2(double d2)
    {
        if (d2 <= 0)
            throw new ArgumentException("D2 must be greater than zero.");
    }
}