using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagement.Poco
{
    [Table("App_CompanyBranchInfo")]
    public class AppCompanyBranchInfoPoco : IPoco
    {
        [Key]
        public int BranchId { get; set; }
        public int CompanyId { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string ContactNumber { get; set; }
        public string EmailAddress { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreateDate { get; set; }
        public int CreatedBy { get; set; }

        
        public virtual AppCompanyInfoPoco AppCompanyInfoPoco { get; set; }
    }
}
