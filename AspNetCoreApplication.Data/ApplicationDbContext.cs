using AspNetCoreApplication.Data.Mapping;
using AspNetCoreApplication.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreApplication.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public ApplicationDbContext()
        {

        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new ProductMap(modelBuilder.Entity<Product>());
        }
    }
}
