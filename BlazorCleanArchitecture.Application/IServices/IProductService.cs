using BlazorCleanArchitecture.Domain.Models;

namespace BlazorCleanArchitecture.Application.IServices
{
    public interface IProductService
    {
        public List<Product> GetAllProducts();
        public Product? GetProductById(int id);
        public void AddProduct(Product product);
        public void UpdateProduct(Product product);
        public void DeleteProduct(int id);
    }
}
