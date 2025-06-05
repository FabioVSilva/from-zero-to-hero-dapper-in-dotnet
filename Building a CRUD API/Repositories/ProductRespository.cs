using System.Data;
using Building_a_CRUD_API.Models;
using Dapper;

namespace Building_a_CRUD_API.Repositories;

public class ProductRespository : IProductRepository
{
    
    private IDbConnection _connection;

    public ProductRespository(IDbConnection connection)
    {
        _connection = connection;
    }
    
    public async Task<IEnumerable<Product>> GetAllAsync()
    {
        var sql = "SELECT * FROM SalesLT.Product";
        return await _connection.QueryAsync<Product>(sql);
    }

    public async Task<Product> GetByIdAsync(int id)
    {
        var sql = "SELECT * FROM SalesLT.Product WHERE ProductId = @ProductId";
        return await _connection.QueryFirstOrDefaultAsync<Product>(sql, new { ProductId = id });
    }

    public async Task<int> InsertAsync(Product product)
    {
        var sql = @"INSERT INTO SalesLT.Product (
        ProductId,
        Name,
        ProductNumber,
        Color,
        StandardCost,
        ListPrice,
        Size,
        Weight,
        ProductCategoryId,
        ProductModelId,
        SellStartDate,
        SellEndDate,
        DiscontinuedDate,
        ThumbNailPhoto,
        ThumbnailPhotoFileName,
        rowguid,
        ModifiedDate
    ) VALUES (
        @ProductId,
        @Name,
        @ProductNumber,
        @Color,
        @StandardCost,
        @ListPrice,
        @Size,
        @Weight,
        @ProductCategoryId,
        @ProductModelId,
        @SellStartDate,
        @SellEndDate,
        @DiscontinuedDate,
        @ThumbNailPhoto,
        @ThumbnailPhotoFileName,
        @rowguid,
        @ModifiedDate
    )
SELECT CAST(SCOPE_IDENTITY() AS INT);";
        var productId = _connection.ExecuteScalar<int>(sql, product);
        return productId;  
    }

    public async Task<int> UpdateAsync(Product product)
    {
        var sql = @"UPDATE SalesLT.Product
            SET
                Name = @Name,
                ProductNumber = @ProductNumber,
                Color = @Color,
                StandardCost = @StandardCost,
                ListPrice = @ListPrice,
                Size = @Size,
                Weight = @Weight,
                ProductCategoryId = @ProductCategoryId,
                ProductModelId = @ProductModelId,
                SellStartDate = @SellStartDate,
                SellEndDate = @SellEndDate,
                DiscontinuedDate = @DiscontinuedDate,
                ThumbNailPhoto = @ThumbNailPhoto,
                ThumbnailPhotoFileName = @ThumbnailPhotoFileName,
                rowguid = @rowguid,
                ModifiedDate = @ModifiedDate
            WHERE ProductId = @ProductId;
            ";
        return await _connection.ExecuteAsync(sql, product);
    }

    public async Task<int> DeleteAsync(int id)
    {
        var sql = @"DELETE FROM SalesLT.Product WHERE ProductId = @ProductId";
        return await _connection.ExecuteAsync(sql, new { ProductId = id });
    }
}