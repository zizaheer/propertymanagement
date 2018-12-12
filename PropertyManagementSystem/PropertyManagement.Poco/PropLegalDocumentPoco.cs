using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagement.Poco
{
    [Table("Prop_LegalDocument")]
    public class PropLegalDocumentPoco
    {
        [Key]
        public int DocumentId { get; set; }
        public int DocumentTypeId { get; set; }
        public string DocumentTitle { get; set; }
        public byte?[] DocumentFile { get; set; }
        public bool IsPublic { get; set; }
        public bool IsReadOnly { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreateDate { get; set; }
        public int CreatedBy { get; set; }
    }
}
