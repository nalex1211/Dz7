Creator creator = new ConcretePc();
Console.Write("What pc do you want?(Intel-I, Amd-A): ");
string choice = Console.ReadLine() ?? throw new ArgumentNullException(nameof(choice));
creator.FactoryMethod(choice).Info();
