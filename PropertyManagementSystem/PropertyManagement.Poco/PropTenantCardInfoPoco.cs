using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagement.Poco
{
    [Table("Prop_TenantCardInfo")]
    public class PropTenantCardInfoPoco
    {
        [Key]
        public int CardId { get; set; }
        public int UserId { get; set; }
        public int CardTypeId { get; set; }
        public string CardName { get; set; }
        public string CardNumber { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string CVV { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreateDate { get; set; }
        public int CreatedBy { get; set; }
    }
}
