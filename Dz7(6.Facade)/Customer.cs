class Customer
{
    public string? Name { get; }
    public string? SurName { get; }
    public string? DateOfBirth { get; }

    public Customer(string? name, string? surName, string? dateOfBirth)
    {
        Name = name;
        SurName = surName;
        DateOfBirth = dateOfBirth;
    }
}
