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
		public virtual Category Category { get; set; }
		public string TradeMark { get; set; }	
		public string Model { get; set; }
		public decimal UnitPrice { get; set; }
		public string Memory { get; set; }		
		public string OperatingSystem { get; set; }
		public string Ram { get; set; }
		public string Camera { get; set; }
			   		 	  	  	 
	}
}
