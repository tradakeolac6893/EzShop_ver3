using EzShop_Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EzShop_Data.Entities
{
    //[Table("Actions")]
    public class Transactions
    {
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public int ExternalTransactionId { get; set; }
        public int Amount { get; set; }
        public float Fee { get; set; }
        public float Result { get; set; }
        public string Message { get; set; }
        public TransactionStatus Status { get; set; }
        public Guid UserId { get; set; }

        //public AppUser AppUser { get; set; }
    }
}
