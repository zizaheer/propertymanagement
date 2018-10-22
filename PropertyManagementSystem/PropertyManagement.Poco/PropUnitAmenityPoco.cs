using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagement.Poco
{
    [Table("Prop_UnitAmenity")]
    public class PropUnitAmenityPoco
    {
        [Key]
        public int UnitId { get; set; }
        public int AmenityId { get; set; }
        public bool IsFree { get; set; }
        public decimal FeeAmount { get; set; }
        public int PaymentIntervalId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreatedBy { get; set; }
    }
}
