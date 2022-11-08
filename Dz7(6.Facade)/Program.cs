Credit credit = new Credit();
Customer customer = new Customer("Robert", "Bateman", "27-03-1987");
credit.Info(customer);
bool approved = credit.IsGrantedCredit(customer);
Console.WriteLine(approved ? "Credit Approved" : "Credit Rejected");
