namespace AbstractFactory;

// ConcreteFactory1
class FordFactory : ICarFactory
{
    // from CarFactory
    Car ICarFactory.CreateCar()
    {
        return new Ford();
    }
    Engine ICarFactory.CreateEngine()
    {
        return new FordEngine();
    }
}

