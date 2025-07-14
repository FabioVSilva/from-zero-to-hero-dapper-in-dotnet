using Building_a_CRUD_API.Models;

namespace Building_a_CRUD_API.Repositories;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAllAsync();
    Task<Product> GetByIdAsync(int id);
    Task<int> InsertAsync(Product product);
    Task<int> UpdateAsync(Product product);
    Task<int> DeleteAsync(int id);
}