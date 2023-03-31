using Microsoft.EntityFrameworkCore;
using PcStation.Models;

namespace PcStation.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }

    public DbSet<Barcode> Barcodes { get; set; }

    public DbSet<Group> Groups { get; set; }

    public DbSet<Category> Categories { get; set; }

    public DbSet<Subcategory> Subcategories { get; set; }

    public DbSet<Filter> Filters { get; set; }

    public DbSet<Image> Images { get; set; }

    public DbSet<ProductImages> ProductImages { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>()
            .HasMany(c => c.Barcodes)
            .WithOne(e => e.Product);
      
 

        modelBuilder.Entity<Group>()
            .HasMany(c => c.Categories)
            .WithOne(e => e.Group);


        modelBuilder.Entity<Category>()
            .HasMany(c => c.Subcategories)
            .WithOne(e => e.Category);


        //dikes m enwseis

        modelBuilder.Entity<Product>()
           .HasMany(c => c.Groups)
           .WithMany(e => e.Products);

        modelBuilder.Entity<Product>()
           .HasMany(c => c.Categories)
           .WithMany(e => e.Products);

        modelBuilder.Entity<Product>()
           .HasMany(c => c.Subcategories)
           .WithMany(e => e.Products);

        modelBuilder.Entity<Product>()
           .HasMany(c => c.Filters)
           .WithMany(e => e.Products);

        modelBuilder.Entity<Product>()
           .HasMany(c => c.ProductImages)
           .WithOne(e => e.Product);

        modelBuilder.Entity<Image>()
           .HasMany(c => c.ProductImages)
           .WithOne(e => e.Image);



    }
}