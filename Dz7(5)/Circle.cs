namespace PrototypeFigure;

class Circle : IFigure
{
    private int radius;
    public Circle(int r)
    {
        radius = r;
    }
    public IFigure Clone()
    {
        return new Circle(radius);
    }
    public void GetInfo()
    {
        Console.WriteLine($"Круг радіусом {radius}");
    }
}