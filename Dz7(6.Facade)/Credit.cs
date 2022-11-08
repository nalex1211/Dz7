class Credit
{
    CreditScore creditScore;
    Bank bank;

    public Credit()
    {
        creditScore = new CreditScore();
        bank = new Bank();
    }

    public bool IsGrantedCredit(Customer customer)
    {
        if (bank.HasMoneyToContribute(customer) & creditScore.checkCustomerScore(customer))
        {
            return true;
        }
        return false;
    }

    public void Info(Customer customer)
    {
        Console.WriteLine(
            $"Name: {customer.Name}\n" +
            $"Surname: {customer.SurName}\n" +
            $"Date of birth: {customer.DateOfBirth}\n" +
            $"Credit score: {creditScore.Score}\n" +
            $"Money available: {bank.Money}");
    }
}