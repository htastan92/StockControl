using StockControl.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControl.Data.Builders
{
	public class PersonelBuilder
	{
		public PersonelBuilder(EntityTypeConfiguration<Personel> builder)
		{
			builder.HasKey(a => a.Id);
			builder.Property(a => a.FirstName).IsRequired().HasMaxLength(50);
			builder.Property(a => a.LastName).IsRequired().HasMaxLength(50);
			builder.Property(a => a.Gender).IsRequired();
			builder.Property(a => a.AuthorityLevel).IsRequired();
			builder.Property(a => a.BirthDate).IsRequired();
			builder.Property(a => a.Phone).HasMaxLength(11);
			builder.Property(a => a.Email).HasMaxLength(50);
			

		}
	}
}
