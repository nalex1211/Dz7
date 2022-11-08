class CreditScore
{
    public int Score { get; } = Random.Shared.Next(1, 100);
    public bool checkCustomerScore(Customer customer)
    {
        Console.WriteLine($"Checking credit score of {customer.Name}: {(Score > 40 ? "Enough" : "Not Enough")}");
        return Score > 40 ? true : false;
    }
}
