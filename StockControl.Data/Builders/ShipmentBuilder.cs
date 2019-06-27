using StockControl.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControl.Data.Builders
{
	public class ShipmentBuilder
	{
		public ShipmentBuilder(EntityTypeConfiguration<Shipment> builder)
		{
			builder.HasKey(a => a.Id);
			builder.Property(a => a.Name).IsRequired().HasMaxLength(50);
			builder.Property(a => a.Phone).IsRequired().HasMaxLength(11);
			builder.Property(a => a.Price).HasPrecision(18, 2).IsRequired();
			builder.Property(a => a.Adress).IsRequired().HasMaxLength(100);
		}
	}
}
