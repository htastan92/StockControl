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
			modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
		}
	}
}
