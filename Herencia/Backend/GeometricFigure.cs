namespace GeometricFigures.Backend;

public abstract class GeometricFigure
{
    protected GeometricFigure(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public abstract double GetArea();

    public abstract double GetPerimeter();

    public override string ToString()
    {
        return $"{Name,-15} => Area.....: {GetArea(),15:F5}    Perimeter: {GetPerimeter(),15:F5}";
    }
}
