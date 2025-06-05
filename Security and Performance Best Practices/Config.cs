using DapperConsole.Models;

namespace DapperConsole;

public static class Config
{
    public static string ConnectionString { get; set; }

    static Config()
    {
        ConnectionString = Environment.GetEnvironmentVariable("DAPPERCOURSECONNECTIONSTRING");
    }
    

}


