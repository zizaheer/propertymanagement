using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagement.Poco
{
    [Table("Prop_Notice")]
    public class PropNoticePoco
    {
        [Key]
        public int NoticeId { get; set; }
        public int NoticeTypeId { get; set; }
        public int? TenantId { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreateDate { get; set; }
        public int CreatedBy { get; set; }
    }
}
