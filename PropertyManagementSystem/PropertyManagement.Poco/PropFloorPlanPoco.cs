using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagement.Poco
{
    [Table("Prop_FloorPlan")]
    public class PropFloorPlanPoco
    {
        [Key]
        public int FloorPlanId { get; set; }
        public int PropertyId { get; set; }
        public int UnitTypeId { get; set; }
        public string FloorPlanDescription { get; set; }
        public byte?[] Picture1 { get; set; }
        public byte?[] Picture2 { get; set; }
        public byte?[] Picture3 { get; set; }
        public byte?[] Floor3DView { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreatedBy { get; set; }
    }
}
