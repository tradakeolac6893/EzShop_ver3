using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EzShop_Data.Entities
{
    //[Table("Carts")]
    public class Carts
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public float Quantity { get; set; }
        public float? Price { get; set; }
        public Product Product { get; set; }
    }
}
