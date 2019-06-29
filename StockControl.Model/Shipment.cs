using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockControl.Model
{
	public	class Shipment : BaseEntity
	{
		[Required]
		[StringLength(50)]
		public string Name { get; set; }		
		public string Adress { get; set; }		
		public string Phone { get; set; }
		[Required]		
		public decimal Price { get; set; }
		public virtual ICollection<Sale> Sales { get; set; }
	}
}
