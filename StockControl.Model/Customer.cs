using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockControl.Model
{
	public class Customer : BaseEntity
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public Gender Gender { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
		public string Adress { get; set; }
		public string City { get; set; }		
		public string Region { get; set; }
		public virtual ICollection<Sale> Purchases { get; set; }
	}
}
