using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagement.Poco
{
    [Table("Prop_NoticeType")]
    public class PropNoticeTypePoco
    {
        [Key]
        public int NoticeTypeId { get; set; }
        public string TypeName { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreatedBy { get; set; }

    }
}
