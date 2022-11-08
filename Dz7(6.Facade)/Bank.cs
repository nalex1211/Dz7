class Bank
{
    public int Money { get; } = Random.Shared.Next(1000, 100000);
    public bool HasMoneyToContribute(Customer customer)
    {
        Console.WriteLine($"Checking balance of {customer.Name}: {(Money > 27000 ? "Enough" : "Not Enough")}");
        return Money > 27000 ? true : false;
    }
}
