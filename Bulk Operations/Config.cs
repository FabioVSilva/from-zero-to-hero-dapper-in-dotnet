using DapperConsole.Models;

namespace DapperConsole;

public static class Config
{
    public static string ConnectionString { get; set; }

    static Config()
    {
        ConnectionString = Environment.GetEnvironmentVariable("DAPPERCOURSECONNECTIONSTRING");
    }
    
    
    public static List<Product> dummyProducts = new List<Product>
    {
        new Product
        {
            ProductId = 1,
            Name = "Mountain Bike",
            ProductNumber = "BK-M68B-42",
            Color = "Red",
            StandardCost = 500.00m,
            ListPrice = 749.99m,
            Size = "M",
            Weight = 15.5m,
            ProductCategoryId = 1,
            ProductModelId = 101,
            SellStartDate = DateTime.UtcNow,
            SellEndDate = DateTime.UtcNow.AddYears(2),
            DiscontinuedDate = null,
            ThumbNailPhoto = null,
            ThumbnailPhotoFileName = "mountainbike.jpg",
            rowguid = Guid.NewGuid(),
            ModifiedDate = DateTime.UtcNow
        },
        new Product
        {
            ProductId = 2,
            Name = "Road Bike",
            ProductNumber = "BK-R79Y-44",
            Color = "Blue",
            StandardCost = 450.00m,
            ListPrice = 699.99m,
            Size = "L",
            Weight = 14.2m,
            ProductCategoryId = 2,
            ProductModelId = 102,
            SellStartDate = DateTime.UtcNow,
            SellEndDate = DateTime.UtcNow.AddYears(2),
            DiscontinuedDate = null,
            ThumbNailPhoto = null,
            ThumbnailPhotoFileName = "roadbike.jpg",
            rowguid = Guid.NewGuid(),
            ModifiedDate = DateTime.UtcNow
        },
        new Product
        {
            ProductId = 3,
            Name = "Touring Bike",
            ProductNumber = "BK-T88G-38",
            Color = "Green",
            StandardCost = 520.00m,
            ListPrice = 799.99m,
            Size = "S",
            Weight = 16.8m,
            ProductCategoryId = 3,
            ProductModelId = 103,
            SellStartDate = DateTime.UtcNow,
            SellEndDate = DateTime.UtcNow.AddYears(2),
            DiscontinuedDate = null,
            ThumbNailPhoto = null,
            ThumbnailPhotoFileName = "touringbike.jpg",
            rowguid = Guid.NewGuid(),
            ModifiedDate = DateTime.UtcNow
        }
    };

    
    
}


