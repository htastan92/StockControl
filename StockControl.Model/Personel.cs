using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockControl.Model
{
	public class Personel:BaseEntity
	{
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
		[Required]
		[StringLength(50)]
=======
>>>>>>> parent of e3d2f13... New Update
=======
>>>>>>> parent of e3d2f13... New Update
=======
>>>>>>> parent of e3d2f13... New Update
		public string FirstName { get; set; }
		[Required]
		[StringLength(50)]
		public string LastName { get; set; }
		[Required]
		public virtual Gender Gender { get; set; }
		[Required]	
		public AuthorityLevel AuthorityLevel { get; set; }
		public DateTime BirthDate { get; set; }	
		public string Phone { get; set; }	
		public string Email { get; set; }
		public virtual ICollection<Sale> Sales { get; set; }
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
		
=======
		public virtual ICollection<Stock> Stocks { get; set; }
>>>>>>> parent of e3d2f13... New Update
=======
		public virtual ICollection<Stock> Stocks { get; set; }
>>>>>>> parent of e3d2f13... New Update
=======
		public virtual ICollection<Stock> Stocks { get; set; }
>>>>>>> parent of e3d2f13... New Update

	}
}
