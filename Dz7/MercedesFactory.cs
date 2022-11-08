namespace AbstractFactory;

class MercedesFactory : ICarFactory
{
    Car ICarFactory.CreateCar()
    {
        return new Mercedes();
    }

    Engine ICarFactory.CreateEngine()
    {
        return new MercedesEngine();
    }
}
