using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagement.Poco
{
    [Table("Prop_TenantDocument")]
    public class PropTenantDocumentPoco
    {
        [Key]
        public int DocumentId { get; set; }
        public int DocumentTypeId { get; set; }
        public int ApplicationId { get; set; }
        public int? TenantId { get; set; }
        public bool IsValid { get; set; }
        public byte?[] DocumentFile { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime SubmissionDate { get; set; }
        public string Remarks { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreateDate { get; set; }
        public int CreatedBy { get; set; }

    }
}
