using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockControl.Model
{
	public class Sale :BaseEntity
	{
		public int PersonelId { get; set; }
		[ForeignKey("PersonelId")]
		public virtual Personel Personel { get; set; }
		public int ProductId { get; set; }
		[ForeignKey("ProductId")]
		public virtual Product Product { get; set; }
		public int StockId { get; set; }
		[ForeignKey("StockId")]
		public virtual Stock Stock { get; set; }
		public int CustomerId { get; set; }
		[ForeignKey("CustomerId")]
		public virtual Customer Customer { get; set; }
		[Required]		
		public decimal Amount { get; set; }
		public int ShipmentId { get; set; }
		[ForeignKey("ShipmentId")]
		public virtual Shipment Shipment { get; set; }
		public DateTime SellingDate { get; set; }
	}
}

// Sale > Personel Id: 5 > Hüseyin > Product Id: 3 > iPhone XS > Stock.Product > Id: 1 () > Customer Id: 10 > Muhsin > 1 > Aras Kargo > 28.06.2019