namespace GeometricFigures.Backend;

public class Triangle : Rectangle
{
    private readonly double _c;
    private readonly double _h;

    public Triangle(
        string name,
        double a,
        double b,
        double c,
        double h) : base(name, a, b)
    {
        ValidateC(c);
        ValidateH(h);

        _c = c;
        _h = h;
    }

    public double C => _c;

    public double H => _h;

    public override double GetArea()
    {
        return (B * H) / 2;
    }

    public override double GetPerimeter()
    {
        return A + B + C;
    }

    private static void ValidateC(double c)
    {
        if (c <= 0)
            throw new ArgumentException("C must be greater than zero.");
    }

    private static void ValidateH(double h)
    {
        if (h <= 0)
            throw new ArgumentException("The height must be greater than zero.");
    }
}