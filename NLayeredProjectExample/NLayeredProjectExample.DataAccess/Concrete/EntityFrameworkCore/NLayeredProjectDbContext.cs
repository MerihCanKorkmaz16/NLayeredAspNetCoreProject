using Microsoft.EntityFrameworkCore;
using NLayeredProjectExample.DataAccess.Concrete.EntityFrameworkCore.Mappings;
using NLayeredProjectExample.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayeredProjectExample.DataAccess.Concrete.EntityFrameworkCore
{
    public class NLayeredProjectDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source =CASPER;Database=NLayeredProject;integrated security=true;Connection Timeout=1800;MultipleActiveResultSets=True");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Category>(new CategoryMap());
            modelBuilder.ApplyConfiguration<Product>(new ProductMap());
            modelBuilder.ApplyConfiguration<ProductImage>(new ProductImageMap());
        }

    }
}
