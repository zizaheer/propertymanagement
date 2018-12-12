using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagement.Poco
{
    [Table("Prop_EnquiryType")]
    public class PropEnquiryTypePoco
    {
        [Key]
        public int EnquiryTypeId { get; set; }
        public string TypeName { get; set; }
        public bool IsActive { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreateDate { get; set; }
        public int CreatedBy { get; set; }
    }
}
