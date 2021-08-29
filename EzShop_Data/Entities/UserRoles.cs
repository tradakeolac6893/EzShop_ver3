using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EzShop_Data.Entities
{
    //[Table("UserRoles")]
    public class UserRoles
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
}
