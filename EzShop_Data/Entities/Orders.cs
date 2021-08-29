using EzShop_Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EzShop_Data.Entities
{
    [Table("Orders")]
    public class Orders
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int UserId { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipEmail { get; set; }
        public string ShipPhone { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }

    }
}
