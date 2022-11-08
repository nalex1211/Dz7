namespace AbstractFactory;

// ConcreteFactory2
class ToyotaFactory : ICarFactory
{
    // from CarFactory
    Car ICarFactory.CreateCar()
    {
        return new Toyota();
    }
    Engine ICarFactory.CreateEngine()
    {
        return new ToyotaEngine();
    }
}

