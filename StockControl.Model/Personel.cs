﻿using System;
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
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public virtual Gender Gender { get; set; }
		public AuthorityLevel AuthorityLevel { get; set; }
		public DateTime BirthDate { get; set; }	
		public string Phone { get; set; }	
		public string Email { get; set; }
		public ICollection<Sale> Sales { get; set; }

	}
}
