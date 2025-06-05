namespace DapperConsole.Models;

public class ProductPartial
{
    public int ProductID { get; set; }
    public string Name { get; set; }
    public string ProductNumber { get; set; }
    public string? Color { get; set; }
    public decimal StandardCost { get; set; }
}