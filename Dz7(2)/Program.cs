using Builder;

Waiter waiter = new Waiter();
PizzaBuilder hawaiianPizzaBuilder = new HawaiianPizzaBuilder();
//PizzaBuilder spicyPizzaBuilder = new SpicyPizzaBuilder();
//PizzaBuilder margaritaPizzaBuilder = new MargaritaPizzaBuilder();

Console.WriteLine("Hawaiian pizza:");
waiter.SetPizzaBuilder(hawaiianPizzaBuilder);
waiter.ConstructPizza();
Pizza pizza = waiter.GetPizza();
pizza.Info();

//Console.WriteLine("\nSpicy pizza:");
//waiter.SetPizzaBuilder(spicyPizzaBuilder);
//waiter.ConstructPizza();
//pizza = waiter.GetPizza();
//pizza.Info();

//Console.WriteLine("\nMargarita pizza:");
//waiter.SetPizzaBuilder(margaritaPizzaBuilder);
//waiter.ConstructPizza();
//pizza = waiter.GetPizza();
//pizza.Info();
