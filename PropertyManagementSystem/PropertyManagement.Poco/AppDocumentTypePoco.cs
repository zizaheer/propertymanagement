using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagement.Poco
{
    [Table("App_DocumentType")]
    public class AppDocumentTypePoco
    {
        [Key]
        public int DocumentTypeId { get; set; }
        public int CategoryId { get; set; }
        public string DocumentName { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreatedBy { get; set; }

        public AppDocumentCategoryPoco documentCategoryPoco { get; set; }
    }
}
