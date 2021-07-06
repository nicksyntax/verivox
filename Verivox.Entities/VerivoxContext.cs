using Microsoft.EntityFrameworkCore;

namespace Verivox.Entities
{
    public class VerivoxContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=VerivoxDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasOne<ProductType>(p => p.ProductType)
                .WithMany(pt => pt.Products)
                .HasForeignKey(p => p.ProductTypeId);

            #region InitialDataSeeding
            // Product Type
            modelBuilder.Entity<ProductType>().HasData(new ProductType { ProductTypeId = 1, ProductTypeName= "Base Cost Based" });
            modelBuilder.Entity<ProductType>().HasData(new ProductType { ProductTypeId = 2, ProductTypeName= "Threshold Based" });

            // Products
            modelBuilder.Entity<Product>().HasData(new Product { 
                ProductId = 1, 
                ProductName = "Basic electricity tariff",
                ProductTypeId = 1,
                MonthlyBaseValue= 5,
                Cost = 22
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                ProductName = "Packaged tariff",
                ProductTypeId = 2,
                Cost = 800,
                ConsumptionThreshold = 4000,
                AdditionalCostPerKwh = 30
            });
            #endregion
        }
    }
}
