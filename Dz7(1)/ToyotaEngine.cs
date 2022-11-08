namespace AbstractFactory;

//ConcreteProductB2
class ToyotaEngine : Engine
{
    public override void GetPower()
    {
        Console.WriteLine("Toyota Engine 3.2");
    }
}

