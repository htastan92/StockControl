using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockControl.Model
{
	public class Product : BaseEntity
	{
		public int CategoryId { get; set; }
		[ForeignKey("CategoryId")]
		public virtual Category Category { get; set; }
		[Required]
		[StringLength(50)]
		public string TradeMark { get; set; }
		[Required]
		[StringLength(50)]
		public string Model { get; set; }
		[Required]
		public decimal UnitPrice { get; set; }
		[Required]	
		public string Memory { get; set; }
		[Required]		
		public string OperatingSystem { get; set; }
		[Required]
		public string Ram { get; set; }
		[Required]	
		public string Camera { get; set; }
		public virtual ICollection<Stock> Stocks { get; set; }
		public virtual ICollection<Sale> Sales { get; set; }

	}
}
