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
			builder.HasRequired(s => s.Product);
			builder.HasRequired(s => s.Stock);
			builder.HasRequired(s => s.Customer);
			builder.Property(s => s.Amount).HasPrecision(18, 2).IsRequired();
			builder.HasRequired(s => s.Shipment);
			builder.Property(s=>s.SellingDate).IsRequired();
		}
	}
}
