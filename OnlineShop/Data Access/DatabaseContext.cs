using OnlineShop.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace OnlineShop.DataAccess
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext() : base("OnlineShopDBContext")
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Log> Logs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Order>().
              HasMany(c => c.Products).
              WithMany(p => p.Orders).
              Map(
               m =>
               {
                   m.MapLeftKey("Product_ID");
                   m.MapRightKey("Order_ID");
                   m.ToTable("ProductOrder");
               });
       

        modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public System.Data.Entity.DbSet<OnlineShop.Models.BillingAddress> BillingAddresses { get; set; }

        public System.Data.Entity.DbSet<OnlineShop.Models.DeliveryAddress> DeliveryAddresses { get; set; }

        public System.Data.Entity.DbSet<OnlineShop.Models.PaymentInformation> PaymentInformations { get; set; }
    }
}