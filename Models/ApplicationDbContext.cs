using Microsoft.EntityFrameworkCore;
using E_Commerce.Models;

namespace E_Commerce.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Payments> Payments { get; set; }
        public DbSet<Categories> Categories { get; set; }
    }
}