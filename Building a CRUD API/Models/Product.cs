namespace Building_a_CRUD_API.Models;

public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public string ProductNumber { get; set; }
    public string? Color { get; set; }
    public decimal StandardCost { get; set; }
    public decimal ListPrice { get; set; }
    public string? Size { get; set; }
    public decimal? Weight { get; set; }
    public int? ProductCategoryId { get; set; }
    public int? ProductModelId { get; set; }
    public DateTime SellStartDate { get; set; }
    public DateTime SellEndDate { get; set; }
    public DateTime? DiscontinuedDate { get; set; }
    public byte[]? ThumbNailPhoto { get; set; }
    public string? ThumbnailPhotoFileName { get; set; }
    public Guid rowguid { get; set; }
    public DateTime ModifiedDate { get; set; }
}