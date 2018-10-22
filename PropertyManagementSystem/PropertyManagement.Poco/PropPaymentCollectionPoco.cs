using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagement.Poco
{
    [Table("Prop_PaymentCollection")]
    public class PropPaymentCollectionPoco
    {
        [Key]
        public int CollectionId { get; set; }
        public int PaymentTypeId { get; set; }
        public int? TenantId { get; set; }
        public int? UnitId { get; set; }
        public int? MonthId { get; set; }
        public int PaidAmount { get; set; }
        public int? PaymentMadeByUserId { get; set; }
        public int PaymentMethodId { get; set; }
        public DateTime PaymentDate { get; set; }
        public int TransactionId { get; set; }
        public string Remarks { get; set; }
    }
}
