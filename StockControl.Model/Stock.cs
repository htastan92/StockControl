using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockControl.Model
{
	public class Stock:BaseEntity
	{
		//public int ProductId { get; set; }		
		public virtual Product Product { get; set; }
		//public int PersonelId { get; set; }
		public virtual Personel	Personel { get; set; }
		public DateTime StockEntryDate { get; set; }
		public int Quantity { get; set; }
		public  ICollection<Sale> Sales { get; set; }
	}
}

// Her ürün bir stoğa ait
// Bir stok birden fazla ürünü içerebilir mi o zaman

//  StokId: 1 > Product Id: 3 > Apple iPhone XS > Personel Id: 2 > Ahmet > 27.06.2019 >