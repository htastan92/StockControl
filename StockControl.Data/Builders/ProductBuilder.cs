using StockControl.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StockControl.Data.Builders
{
	public class ProductBuilder
	{
		public ProductBuilder(EntityTypeConfiguration<Product> builder)
		{
			builder.HasKey(a => a.Id);
			builder.HasRequired(a => a.Category).WithMany(b => b.Products).HasForeignKey(a => a.CategoryId);
			builder.Property(a => a.TradeMark).IsRequired().HasMaxLength(50);
			builder.Property(a => a.Model).IsRequired().HasMaxLength(50);
			builder.Property(a => a.UnitPrice).HasPrecision(18, 2).IsRequired();
			builder.Property(a => a.Memory).IsRequired().HasMaxLength(50);
			builder.Property(a => a.OperatingSystem).IsRequired().HasMaxLength(50);
			builder.Property(a => a.Camera).HasMaxLength(50).IsRequired();
		}
	}
}
