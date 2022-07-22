using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BankEntityFrameWork.Classes
{
    [Table("operation")]
    public class Operation
    {
        private int id;
        private decimal amount;
        private DateTime operationDateTime;
        private int accountId;
        
        public Operation()
        {

        }
        
        public Operation(decimal amount)
        {
            operationDateTime = DateTime.Now;
            this.amount = amount;
        }

        [Column("amount")]
        [Required]
        public decimal Amount { get => amount; set => amount = value; }

        [Column("operation_date_time")]
        public DateTime OperationDateTime { get => operationDateTime; set => operationDateTime = value; }
        
        public int Id { get => id; set => id = value; }

        [Column("account_id")]
        public int AccountId { get => accountId; set => accountId = value; }

        [JsonIgnore]
        [ForeignKey("AccountId")]
        public Account Account { get; set; }
    }
}
