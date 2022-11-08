namespace AbstractFactory;

// ConcreteProductB1
class FordEngine : Engine
{
    public override void GetPower()
    {
        Console.WriteLine("Ford Engine 4.4");
    }
}

