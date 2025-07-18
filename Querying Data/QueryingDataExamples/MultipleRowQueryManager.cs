﻿using Microsoft.Data.SqlClient;
using Dapper;
using DapperConsole.Models;

namespace DapperConsole.QueryingDataExamples;

public class MultipleRowQueryManager
{
    public async Task<IEnumerable<Product>> GetProductByColourAsync(string colour)
    {
        using var connection = new SqlConnection(Config.ConnectionString);
        var sql = "SELECT * FROM SalesLT.Product WHERE Color = @colour";
        var result = await connection.QueryAsync<Product>(sql, new { @colour });
        return result;
    }
    
    public async Task<IEnumerable<ProductPartial>> GetPartialProductByColourAsync(string colour)
    {
        using var connection = new SqlConnection(Config.ConnectionString);
        var sql = "SELECT * FROM SalesLT.Product WHERE Color = @colour";
        var result = await connection.QueryAsync<ProductPartial>(sql, new { @colour });
        return result;
    }
    
    //synchronous version
    public IEnumerable<Product> GetProductByColour(string colour)
    {
        using var connection = new SqlConnection(Config.ConnectionString);
        var sql = "SELECT * FROM SalesLT.Product WHERE Color = @colour";
        var result = connection.Query<Product>(sql, new { @colour });
        return result;
    }
}