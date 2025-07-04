using Microsoft.EntityFrameworkCore;
using BlazorCleanArchitecture.Domain.Models;

namespace BlazorCleanArchitecture.Infrastructure.Data
{
    class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<Product> Products { get; set; }
    }
}
