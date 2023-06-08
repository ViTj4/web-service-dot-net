namespace webService;
public class Meal
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Type { get; set; } 
}

public class Order
{
    public int Id { get; set; }
    public List<Meal>? Meals { get; set; }
    public string? Status { get; set; } 
}