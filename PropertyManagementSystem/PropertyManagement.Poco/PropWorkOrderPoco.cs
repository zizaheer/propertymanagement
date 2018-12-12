using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagement.Poco
{
    [Table("Prop_WorkOrder")]
    public class PropWorkOrderPoco
    {
        [Key]
        public int WorkOrderId { get; set; }
        public int ContractorId { get; set; }
        public int? MaintenanceIssueId { get; set; }
        public int? UnitId { get; set; }
        public int? PropertyId { get; set; }
        public string WorkOrderDetails { get; set; }
        public decimal? EstimatedCost { get; set; }
        public DateTime WorkStartDate { get; set; }
        public DateTime WorkEndDate { get; set; }
        public string SpecialInstructions { get; set; }
        public byte?[] OrderDocument { get; set; }
        public bool IsActive { get; set; }
        public string Remarks { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreateDate { get; set; }
        public int CreatedBy { get; set; }

    }
}
