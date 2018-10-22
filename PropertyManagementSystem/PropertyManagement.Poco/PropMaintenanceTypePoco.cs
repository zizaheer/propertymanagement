using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagement.Poco
{
    [Table("Prop_MaintenanceType")]
    public class PropMaintenanceTypePoco
    {
        [Key]
        public int MaintenanceTypeId { get; set; }
        public string MaintenanceTypeName { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreatedBy { get; set; }
    }
}
