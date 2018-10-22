using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagement.Poco
{
    [Table("Prop_ChartOfAccount")]
    public class PropChartOfAccountPoco
    {
        [Key]
        public int AccountId { get; set; }
        public string AccountNo { get; set; }
        public int AccountTypeId { get; set; }
        public string AccountName { get; set; }
        public decimal InitialBalance { get; set; }
        public bool IsActive { get; set; }
        public string Remarks { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreatedBy { get; set; }

    }
}
