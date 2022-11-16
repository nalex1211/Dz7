abstract class Creator
{
    public abstract IProduct Create();

    public void Info()
    {
        IProduct product = Create();
        Console.WriteLine($"This car brand is {product.CarBrand()} and has {product.GetHorsePower()} horse powers");
    }
}
