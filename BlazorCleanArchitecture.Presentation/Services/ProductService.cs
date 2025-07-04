using BlazorCleanArchitecture.Domain.Models;
using BlazorCleanArchitecture.Presentation.Configurations;
using Microsoft.Extensions.Options;

namespace BlazorCleanArchitecture.Presentation.Services
{
    public class ProductService
    {
        private readonly HttpClient _httpClient;
        private readonly ApiSettings _apiSettings;

        public ProductService(HttpClient httpClient, IOptions<ApiSettings> options)
        {
            _httpClient = httpClient;
            _apiSettings = options.Value;
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<List<Product>>($"{_apiSettings.ApiUrl}/api/products")
                       ?? new List<Product>();
            }
            catch
            {
                return new List<Product>();
            }
        }

        public async Task<Product?> GetProductByIdAsync(int id)
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<Product>($"{_apiSettings.ApiUrl}/api/products/{id}");
            }
            catch
            {
                return null;
            }
        }

        public async Task AddProductAsync(Product product)
        {
            await _httpClient.PostAsJsonAsync($"{_apiSettings.ApiUrl}/api/products", product);
        }

        public async Task UpdateProductAsync(int id, Product product)
        {
            await _httpClient.PutAsJsonAsync($"{_apiSettings.ApiUrl}/api/products/{id}", product);
        }

        public async Task DeleteProductAsync(int id)
        {
            await _httpClient.DeleteAsync($"{_apiSettings.ApiUrl}/api/products/{id}");
        }
    }
}
