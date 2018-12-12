using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagement.Poco
{
    [Table("App_ScreenPermission")]
    public class AppScreenPermissionPoco : IPoco
    {
        [Key]
        public int PermissionId { get; set; }
        public int GroupId { get; set; }
        public int ScreenId { get; set; }
        public bool IsCreatePermissionAllowed { get; set; }
        public bool IsReadPermissionAllowed { get; set; }
        public bool IsUpdatePermissionAllowed { get; set; }
        public bool IsDeletePermissionAllowed { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreateDate { get; set; }
        public int CreatedBy { get; set; }

    }
}
