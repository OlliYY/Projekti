namespace API.Interfaces
{
    using API.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IProductService
    {
        Task<List<Product>> GetAllProductsAsync();
        Task<List<Category>> GetAllCategoriesAsync();
        Task<List<Product>> GetProductsByCategoryAsync(int categoryId);
    }
}
