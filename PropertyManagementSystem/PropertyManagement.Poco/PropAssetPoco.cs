using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagement.Poco
{
    [Table("Prop_Asset")]
    public class PropAssetPoco
    {
        [Key]
        public int AssetId { get; set; }
        public int AssetTypeId { get; set; }
        public string AssetDescription { get; set; }
        public DateTime AssetAcquireDate { get; set; }
        public int AssetLifeYear { get; set; }
        public decimal AssetValue { get; set; }
        public decimal SalvageValue { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreatedBy { get; set; }

    }
}
