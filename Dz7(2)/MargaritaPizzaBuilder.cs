namespace Builder;

class MargaritaPizzaBuilder : PizzaBuilder
{
    public override void BuildDough()
    {
        pizza.SetDough("Brioche");
    }

    public override void BuildSauce()
    {
        pizza.SetSauce("margarita sauce");
    }

    public override void BuildTopping()
    {
        pizza.SetTopping("parmesan+mozzarella");
    }
}
