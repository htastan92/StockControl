using StockControl.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControl.Data.Builders
{
	public class StockBuilder
	{
		public StockBuilder(EntityTypeConfiguration<Stock> builder)
		{
			builder.HasKey(s => s.Id);
			builder.HasRequired(s => s.Personel).WithMany(a => a.Stocks).HasForeignKey(s => s.PersonelId);
			builder.HasRequired(a => a.Product).WithMany(a => a.Stocks).HasForeignKey(s => s.ProductId);
			builder.Property(a => a.StockEntryDate).IsRequired();
			builder.Property(a => a.Quantity).IsRequired();

		}
	}
}
