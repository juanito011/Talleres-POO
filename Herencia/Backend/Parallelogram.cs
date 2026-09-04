namespace GeometricFigures.Backend;

public class Parallelogram : Rectangle
{
    private readonly double _h;

    public Parallelogram(
        string name,
        double a,
        double b,
        double h) : base(name, a, b)
    {
        ValidateH(h);
        _h = h;
    }

    public double H => _h;

    public override double GetArea()
    {
        return B * H;
    }

    public override double GetPerimeter()
    {
        return 2 * (A + B);
    }

    private static void ValidateH(double h)
    {
        if (h <= 0)
            throw new ArgumentException("The height must be greater than zero.");
    }
}