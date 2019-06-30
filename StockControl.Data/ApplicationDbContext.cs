using StockControl.Data.Builders;
using StockControl.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControl.Data
{
    public class ApplicationDbContext:DbContext
    {
		public ApplicationDbContext():base ("name=DefaultConnection")
		{

		}

		public virtual DbSet<Category> Categories { get; set; }
		public virtual DbSet<Customer> Customers { get; set; }
		public virtual DbSet<Personel> Personels { get; set; }
		public virtual DbSet<Product> Products { get; set; }
		public virtual DbSet<Sale> Sales { get; set; }
		public virtual DbSet<Shipment> Shipments { get; set; }
		public virtual DbSet<Stock> Stocks { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			var categoryBuilder = new CategoryBuilder(modelBuilder.Entity<Category>());
			var customerBuilder = new CustomerBuilder(modelBuilder.Entity<Customer>());
			var personelBuilder = new PersonelBuilder(modelBuilder.Entity<Personel>());
			var productBuilder = new ProductBuilder(modelBuilder.Entity<Product>());
			var saleBuilder = new SaleBuilder(modelBuilder.Entity<Sale>());
			var shipmentBuilder = new ShipmentBuilder(modelBuilder.Entity<Shipment>());
			var stockBuilder = new StockBuilder(modelBuilder.Entity<Stock>());
			modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

		}
	}
}
