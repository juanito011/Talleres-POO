namespace GeometricFigures.Backend;

public class Circle : GeometricFigure
{
    private readonly double _r;

    public Circle(string name, double r) : base(name)
    {
        ValidateR(r);
        _r = r;
    }

    public double R => _r;

    public override double GetArea()
    {
        return Math.PI * Math.Pow(R, 2);
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * R;
    }

    private static void ValidateR(double r)
    {
        if (r <= 0)
            throw new ArgumentException("The radius must be greater than zero.");
    }
}
