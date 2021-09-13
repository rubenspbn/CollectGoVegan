using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeganApi.Models;

namespace VeganApi.Data
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<UnitsAvailable> UnitsAvailables { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Define composite key.
            builder.Entity<UnitsAvailable>()
                .HasKey(ua => new { ua.ProductId, ua.StoreId });
            // Convert Guid to byte[] vice versa
            builder.Entity<Product>().Property(p => p.ProductId).HasConversion(
                v => v.ToString(),
                v => new Guid(v));
            builder.Entity<Store>().Property(p => p.StoreId).HasConversion(
                v => v.ToString(),
                v => new Guid(v));
            builder.Entity<Supplier>().Property(p => p.SupplierId).HasConversion(
                v => v.ToString(),
                v => new Guid(v));
            builder.Entity<UnitsAvailable>().Property(p => p.ProductId).HasConversion(
                v => v.ToString(),
                v => new Guid(v));
            builder.Entity<UnitsAvailable>().Property(p => p.StoreId).HasConversion(
                v => v.ToString(),
                v => new Guid(v));
        }
    }
}
