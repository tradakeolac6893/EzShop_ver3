using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EzShop_Data.Entities
{
    //[Table("Permission")]
    public class Permission
    {
        public int RoleId { get; set; }
        public int FunctionId { get; set; }
        public int ActionId { get; set; }
    }
}
