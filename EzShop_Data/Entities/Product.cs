using EzShop_Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EzShop_Data.Entities
{
    public class Product
    {
		public int Id { get; set; }
		public int CateId { get; set; }
		[Required]
		public string NameProduct { get; set; }
		public string CateName { get; set; }
		public string Unit { get; set; }
		public string Weight { get; set; }
		public string Length { get; set; }
		public string Height { get; set; }
		public string Color { get; set; }
		public string Descrip { get; set; }
		public Status Status { get; set; }
		public string UserCreate { get; set; }
		public string Images { get; set; }
		public decimal Price { set; get; }
		public decimal OriginalPrice { set; get; }
		public int Stock { set; get; }
		public int ViewCount { get; set; }
		public DateTime DateCreate { get; set; }
		public List<Carts> Carts { get; set; }
		public List<ProductTranslation> ProductTranslations { get; set; }
		public List<OrderDetail> OrderDetails { get; set; }
		public List<ProductImage> ProductImages { get; set; }
		public List<ProductInCategory> ProductInCategories { get; set; }
	}
}
