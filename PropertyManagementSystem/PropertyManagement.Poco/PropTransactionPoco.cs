using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagement.Poco
{
    [Table("Prop_Transaction")]
    public class PropTransactionPoco
    {
        [Key]
        public int TransactionId { get; set; }
        public int DeductFromAccount { get; set; } //linked with AccountId of ChartOfAccount table
        public int DepositToAccount { get; set; } //linked with AccountId of ChartOfAccount table
        public decimal TransactionAmount { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime ValueDate { get; set; }
        public string Remarks { get; set; }

    }
}
