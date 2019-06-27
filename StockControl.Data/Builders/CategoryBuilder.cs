using StockControl.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControl.Data.Builders
{
	public class CategoryBuilder
	{
		public CategoryBuilder(EntityTypeConfiguration<Category> builder)
		{
			builder.HasKey(a => a.Id);
			builder.Property(a => a.Name).IsRequired().HasMaxLength(50);
		}
	}
}
