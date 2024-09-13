using Ec2WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace Ec2WebApi
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {
        }
    }
}
