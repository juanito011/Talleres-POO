namespace GeometricFigures.Backend;

public class Triangle : Rectangle
{
    private  double _c;
    private  double _h;

    public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
    {
        _c = c;
        _h = h;
    }

    public double H
    {
        get => _h;
        set => _h = ValidateH(value);
    }
    public double C
    {
        get => _c;
        set => _c = ValidateC(value);
    }

    public override double GetArea()
    {
        return (B * H) / 2;
    }

    public override double GetPerimeter()
    {
        return A + B + C;
    }

    private double ValidateH(double b)
    {
        if (b <= 0)
        {
            throw new Exception("B must be greater than zero.");
        }
        return b;
    }

    private double ValidateC(double c)
    {
        if (c <= 0)
        {
            throw new Exception("C must be greater than zero.");
        }
        return c;
    }
}