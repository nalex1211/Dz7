namespace PrototypeFigure;

class Triangle : IFigure
{
    private int firstSide;
    private int secondSide;
    private int thirdSide;

    public Triangle(int f, int s, int t)
    {
        firstSide = f;
        secondSide = s;
        thirdSide = t;
    }

    public IFigure Clone()
    {
        return new Triangle(firstSide, secondSide, thirdSide);
    }

    public void GetInfo()
    {
        Console.WriteLine($"Трикутник зі сторонами {firstSide}, {secondSide}, {thirdSide}");
    }
}
