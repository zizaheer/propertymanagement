using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagement.Poco
{
    [Table("Prop_MaintenanceIssue")]
    public class PropMaintenanceIssuePoco
    {
        [Key]
        public int MaintenanceIssueId { get; set; }
        public int UnitId { get; set; }
        public int MaintenanceTypeId { get; set; }
        public int ProblemDescription { get; set; }
        public byte?[] Picture1 { get; set; }
        public byte?[] Picture2 { get; set; }
        public byte?[] Picture3 { get; set; }
        public byte?[] Picture4 { get; set; }
        public byte?[] Picture5 { get; set; }
        public bool IsPredeliveryIssue { get; set; }
        public string Severity { get; set; }
        public string IssueStatus { get; set; }
        public DateTime ReportDate { get; set; }
        public DateTime ResolveDate { get; set; }
        public string Remarks { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreateDate { get; set; }
        public int CreatedBy { get; set; }
    }
}
