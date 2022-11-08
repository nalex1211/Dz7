using AbstractFactory;

ICarFactory carFactory = new ToyotaFactory();
Car myCar = carFactory.CreateCar();
myCar.Info();
Engine myEngine = carFactory.CreateEngine();
myEngine.GetPower();
Console.WriteLine();

carFactory = new FordFactory();
myCar = carFactory.CreateCar();
myCar.Info();
myEngine = carFactory.CreateEngine();
myEngine.GetPower();
Console.WriteLine();


carFactory = new MercedesFactory();
myCar = carFactory.CreateCar();
myCar.Info();
myEngine = carFactory.CreateEngine();
myEngine.GetPower();


