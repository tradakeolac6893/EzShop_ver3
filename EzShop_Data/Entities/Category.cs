using EzShop_Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EzShop_Data.Entities
{
	[Table("Category")]
	public class Category
	{
		public int Id { get; set; }
		public string CateName { get; set; }
		public string CreateDate { get; set; }
		public string UserCreate { get; set; }
		public Status Status { get; set; }
		public string Description { get; set; }
		public int? Parent_id { get; set; }
		public string Images { get; set; }
		public string Avata { get; set; }
		public List<ProductInCategory> ProductInCategories { get; set; }
		public List<CategoryTranslation> CategoryTranslations { get; set; }
	}
}
