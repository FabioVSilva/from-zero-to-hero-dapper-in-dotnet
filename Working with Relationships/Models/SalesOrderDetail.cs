namespace DapperConsole.Models;

public class SalesOrderDetail
{
    public int SalesOrderDetailId { get; set; }
    public int ProductId { get; set; }
    public int OrderQty { get; set; }
    public decimal LineTotal { get; set; }
}