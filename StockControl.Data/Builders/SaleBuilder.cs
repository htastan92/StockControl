using StockControl.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControl.Data.Builders
{
	public class SaleBuilder
	{
		public SaleBuilder (EntityTypeConfiguration<Sale> builder)
		{
			builder.HasKey(s => s.Id);
			builder.HasRequired(s => s.Product).WithMany(a=>a.Sales).HasForeignKey(s=>s.ProductId);
			builder.HasRequired(s => s.Stock).WithMany(a=>a.Sales).HasForeignKey(s=>s.StockId);
			builder.HasRequired(s => s.Customer).WithMany(c=>c.Purchases).HasForeignKey(s=>s.CustomerId);
			builder.Property(s => s.Amount).HasPrecision(18, 2).IsRequired();
			builder.HasRequired(s => s.Shipment).WithMany(a=>a.Sales).HasForeignKey(s=>s.ShipmentId);
			builder.Property(s=>s.SellingDate).IsRequired();
		}
	}
}
