namespace Builder;

class Pizza
{
    private string? dough;
    private string? sauce;
    private string? topping;
    
    public void SetDough(string d) 
    {
        dough = d; 
    }
    public void SetSauce(string s)
    {
        sauce = s;
    }
    public void SetTopping(string t)
    {
        topping = t; 
    }
    public void Info()
    {
        Console.WriteLine($"Dough: {dough}\nSause: {sauce}\nTopping: {topping}");
    }
}