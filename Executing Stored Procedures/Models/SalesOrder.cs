
namespace DapperConsole.Models;

public class SalesOrder
{
    public int SalesOrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalDue { get; set; }
}