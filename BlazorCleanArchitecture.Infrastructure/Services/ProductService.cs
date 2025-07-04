using BlazorCleanArchitecture.Domain.Models;
using BlazorCleanArchitecture.Application.IServices;
using BlazorCleanArchitecture.Application.IRepo;

namespace BlazorCleanArchitecture.Infrastructure.Services
{
    class ProductService : IProductService
    {
        private readonly IProductRepo _repo;
        public ProductService(IProductRepo repo)
        {
            _repo = repo;
        }
        public void AddProduct(Product product)
        {
            _repo.AddProduct(product);
        }

        public void DeleteProduct(int id)
        {
            _repo.DeleteProduct(id);
        }

        public List<Product> GetAllProducts()
        {
            return _repo.GetAllProducts();
        }

        public Product? GetProductById(int id)
        {
            return _repo.GetProductById(id);
        }

        public void UpdateProduct(Product product)
        {
            _repo.UpdateProduct(product);
        }
    }
}
