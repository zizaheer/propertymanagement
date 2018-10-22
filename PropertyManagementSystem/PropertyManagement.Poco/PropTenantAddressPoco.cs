using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagement.Poco
{
    [Table("Prop_TenantAddress")]
    public class PropTenantAddressPoco
    {
        [Key]
        public int AddressId { get; set; }
        public int TenantId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }
        public DateTime MovedInDate { get; set; }
        public DateTime MovedOutDate { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreatedBy { get; set; }
    }
}
