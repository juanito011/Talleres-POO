namespace GeometricFigures.Backend;

public class Circle : GeometricFigure
{
    private  double _r;

    public Circle(string name, double r)
    {
        Name = name;
        _r = r;
    }

    public double R
    {
        get => _r;
        set => _r = ValidateR(value);
    }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(R, 2);
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * R;
    }

    private double ValidateR(double r)
    {
        if (r <= 0)
        {
            throw new ArgumentException("The radius must be greater than zero.");
        }
        return r;
    }
}
