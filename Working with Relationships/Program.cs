using DapperConsole.Relationship_Examples;

namespace DapperConsole;

class Program
{
    static async Task Main(string[] args)
    {
        var manager = new RelationalQueryManager();
        var orders = await manager.SalesOrderMinAmountDue(1000);
    }
}