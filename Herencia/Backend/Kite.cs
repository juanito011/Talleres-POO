namespace GeometricFigures.Backend;

public class Kite : Rhombus
{
    private double _b;

    public Kite(string name, double a, double b, double d1, double d2) : base(name, a, d1, d2)
    {
        _b = b;
    }

    public double B
    {
        get => _b;
        set => _b = ValidateB(value);
    }

    public override double GetArea()
    {
        return (D1 * D2) / 2;
    }

    public override double GetPerimeter()
    {
        return 2 * (A + B);
    }

    private double ValidateB(double b)
    {
        if (b <= 0)
        {
            throw new Exception("Side length must be greater than zero.");
        }
        return b;
    }
}