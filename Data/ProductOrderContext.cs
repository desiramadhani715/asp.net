using System;
using Microsoft.EntityFrameworkCore;
using ProductOrderCRUD.Models;

namespace ProductOrderCRUD.Data
{
    public class ProductOrderContext : DbContext
    {
        public ProductOrderContext (DbContextOptions<ProductOrderContext> options)
            : base(options)
        {
        }
        // public DbSet<user> User {get;set;}
        // public DbSet<product> Product {get;set;}
        // public DbSet<customer> Customer {get;set;}
    }
}