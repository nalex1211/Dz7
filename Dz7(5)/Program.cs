using System.Text;
using PrototypeFigure;

Console.OutputEncoding = Encoding.UTF8;
IFigure figure = new Rectangle(10, 20);
IFigure clonedFigure = figure.Clone();
figure.GetInfo();
clonedFigure.GetInfo();
Console.WriteLine();

figure = new Circle(15);
clonedFigure = figure.Clone();
figure.GetInfo();
clonedFigure.GetInfo();
Console.WriteLine();

figure = new Triangle(10, 20, 15);
clonedFigure = figure.Clone();
figure.GetInfo();
clonedFigure.GetInfo();