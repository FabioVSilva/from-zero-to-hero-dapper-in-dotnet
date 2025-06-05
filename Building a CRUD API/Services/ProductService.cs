using Building_a_CRUD_API.Models;
using Building_a_CRUD_API.Repositories;

namespace Building_a_CRUD_API.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<IEnumerable<Product>> GetAllProductsAsync()
    {
        return await _productRepository.GetAllAsync();
    }

    public async Task<Product> GetProductByIdAsync(int productId)
    {
        var result = await _productRepository.GetByIdAsync(productId);
        return result ?? throw new NullReferenceException();
    }

    public async Task<int> UpdateProductAsync(Product product)
    {
        return await _productRepository.UpdateAsync(product);
    }

    public async Task DeleteProductAsync(int productId)
    {
        await _productRepository.DeleteAsync(productId);
    }

    public async Task<int> AddProductAsync(Product product)
    {
        return await _productRepository.InsertAsync(product);
    }
    
    

}