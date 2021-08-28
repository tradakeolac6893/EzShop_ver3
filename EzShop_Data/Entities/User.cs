using EzShop_Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EzShop_Data.Entities
{
	//[Table("User")]
	public class User
    {
		public int Id { get; set; }
		public string UserName { get; set; }
		public string Name { get; set; }
		public string Pass { get; set; }
		public DateTime Birthday { get; set; }
		public string Avata { get; set; }
		public int Role { get; set; }
		public string Mail { get; set; }
		public bool Gender { get; set; }
		public string Address { get; set; }
		public string Phone { get; set; }
		public string CreateDate { get; set; }
		public Status Status { get; set; }
	}
}
