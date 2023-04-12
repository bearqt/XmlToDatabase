using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using XmlToDatabase.Data.Models;

namespace XmlToDatabase.Data;

public class DataContext : DbContext
{
    public DataContext()
    {
        
    }
    
    public DataContext(DbContextOptions options) : base(options)
    {
        
    }

    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<OrderProduct> OrderProducts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseNpgsql("Server=localhost; Port=5432; User Id=postgres; Password=HGRMxLa6; Database=ordersDb");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<OrderProduct>()
            .HasKey(op => new { op.OrderId, op.ProductId });

        builder.Entity<Product>()
            .Property(x => x.Id)
            .ValueGeneratedOnAdd();
        
        builder.Entity<User>()
            .Property(x => x.Id)
            .ValueGeneratedOnAdd();
    }
}