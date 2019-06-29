using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControl.Model
{
	public class Category : BaseEntity
	{
		[Required]
		[StringLength(30)]
		public string Name { get; set; }
		public virtual ICollection<Product> Products { get; set; }
	}
}
