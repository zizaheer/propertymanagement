using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagement.Poco
{
    [Table("Prop_TenantPackageCollector")]
    public class PropTenantPackageCollectorPoco
    {
        [Key]
        public int CollectorId { get; set; }
        public int CollectorName { get; set; }
        public int? UnitId { get; set; }
        public int? TenantId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreateDate { get; set; }
        public int CreatedBy { get; set; }

    }
}
