using Microsoft.EntityFrameworkCore;

namespace DataBinding
{
   public class ShopContext : DbContext
   {
      public DbSet<Product> Products { get; set; }
      public string DbPath { get; }

      protected override void OnConfiguring(DbContextOptionsBuilder options) 
         => options.UseSqlite($"Data Source=shop.db");
   }

   public class Product
   {
      public int Id { get; set; }
      public string Name { get; set; }
      public double Price { get; set; }
      public double Amount { get; set; }
   }
}
