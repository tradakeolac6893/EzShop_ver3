using EzShop_Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EzShop_Data.Entities
{
    //[Table("Functions")]
    public class Functions
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int ParentId { get; set; }
        public Status Status { get; set; }
        public int SortOrder { get; set; }
    }
}
