namespace PrototypeFigure;

class Rectangle : IFigure
{
    private int width;
    private int height;
    public Rectangle(int w, int h)
    {
        width = w;
        height = h;
    }
    public IFigure Clone()
    {
        return new Rectangle(width, height);
    }
    public void GetInfo()
    {
        Console.WriteLine($"Прямокутник довжиною {height} и шириною {width}");
    }
}