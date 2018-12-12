using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagement.Poco
{
    [Table("Prop_Unit")]
    public class PropUnitPoco
    {
        [Key]
        public int UnitId { get; set; }
        public int PropertyId { get; set; }
        public int UnitTypeId { get; set; }
        public int AccountId { get; set; }
        public string UnitNo { get; set; }
        public string UnitCaptionLine { get; set; }
        public int UnitSizeSquareFeet { get; set; }
        public int NumberOfBed { get; set; }
        public int NumberOfWashroom { get; set; }
        public int NumberOfCarParking { get; set; }
        public int NumberOfKitchen { get; set; }
        public int NumberOfBalcony { get; set; }
        public bool IsPriceRangeApplicable { get; set; }
        public decimal UnitPricePerInterval { get; set; }
        public int PaymentIntervalId { get; set; }
        public decimal UnitStartPriceRange { get; set; }
        public decimal UnitEndPriceRange { get; set; }
        public DateTime AvailableFrom { get; set; }
        public byte?[] Picture1 { get; set; }
        public byte?[] Picture2 { get; set; }
        public byte?[] Picture3 { get; set; }
        public byte?[] Picture4 { get; set; }
        public byte?[] Picture5 { get; set; }
        public byte?[] Picture6 { get; set; }
        public byte?[] Picture7 { get; set; }
        public byte?[] Picture8 { get; set; }
        public byte?[] Picture9 { get; set; }
        public byte?[] Unit3DView { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsFeatured { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreateDate { get; set; }
        public int CreatedBy { get; set; }

    }
}
