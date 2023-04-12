namespace XmlToDatabase.Data.Models;

public class Order
{
    public int Id { get; set; }
    public DateOnly RegDate { get; set; }
    public decimal Sum { get; set; }
    public User User { get; set; }
}