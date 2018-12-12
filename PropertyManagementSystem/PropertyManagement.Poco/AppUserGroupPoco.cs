using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagement.Poco
{
    [Table("App_UserGroup")]
    public class AppUserGroupPoco : IPoco
    {
        [Key]
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsActive { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreateDate { get; set; }
        public int CreatedBy { get; set; }
    }
}
