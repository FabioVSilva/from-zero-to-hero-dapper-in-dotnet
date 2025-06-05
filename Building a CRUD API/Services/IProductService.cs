using Building_a_CRUD_API.Models;

namespace Building_a_CRUD_API.Services;

public interface IProductService
{
    Task<IEnumerable<Product>> GetAllProductsAsync();
    Task<Product> GetProductByIdAsync(int productId);
    Task<int> AddProductAsync(Product product);
    Task<int> UpdateProductAsync(Product product);
    Task DeleteProductAsync(int productId);
}