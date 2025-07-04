using BlazorCleanArchitecture.Domain.Models;

namespace BlazorCleanArchitecture.Application.IRepo
{
    public interface IProductRepo
    {
        public List<Product> GetAllProducts();
        public Product? GetProductById(int id);
        public void AddProduct(Product product);
        public void UpdateProduct(Product product);
        public void DeleteProduct(int id);
    }
}
