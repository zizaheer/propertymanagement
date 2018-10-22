using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagement.Poco
{
    [Table("App_ProductPricePlan")]
    public class AppProductPricePlanPoco
    {
        [Key]
        public int PlanId { get; set; }
        public int ProductId { get; set; }
        public string PlanTitle { get; set; }
        public decimal? FeePerUnit { get; set; }
        public decimal? FeePerMonth { get; set; }
        public decimal? FeePerYear { get; set; }
        public int MinimumUnitQty { get; set; }
        public decimal? FeePerOnlineTransaction { get; set; }
        public decimal? FeePerScreeningProcess { get; set; }
        public decimal? ImplementationFee { get; set; }
        public string Remarks { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreatedBy { get; set; }

    }
}
