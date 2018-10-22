using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagement.Poco
{
    [Table("Prop_Tenant")]
    public class PropTenantPoco
    {
        [Key]
        public int TenantId { get; set; }
        public int UserId { get; set; }
        public int ApplicationId { get; set; }
        public int UnitId { get; set; }
        public decimal AdvanceAmount { get; set; }
        public string TransactionRef { get; set; }
        public DateTime MoveInDate { get; set; }
        public DateTime ContractStartDate { get; set; }
        public DateTime ContractEndDate { get; set; }
        public DateTime ContractRenewDate { get; set; }
        public int ReferenceDocumentId { get; set; }
        public int RenewedByUserId { get; set; }
        public byte?[] ProfilePicture { get; set; }
        public bool AllowConciergeToReceivePackage { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreatedBy { get; set; }

    }
}
