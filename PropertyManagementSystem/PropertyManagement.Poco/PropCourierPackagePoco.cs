using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagement.Poco
{
    [Table("Prop_CourierPackage")]
    public class PropCourierPackagePoco
    {
        [Key]
        public int CourierPackageId { get; set; }
        public int ForUnitId { get; set; }
        public string ParcelFor { get; set; }
        public int CourierCompanyId { get; set; }
        public string ReceivedBy { get; set; } // name of the person
        public DateTime ReceivedDate { get; set; }
        public int CollectorId { get; set; }
        public DateTime CollectedDate { get; set; }
        public string DocumentShown { get; set; } // name of the ID shown during collection
        public DateTime CreateDate { get; set; }
        public int CreatedBy { get; set; }
    }
}
