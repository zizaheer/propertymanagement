using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagement.Poco
{
    [Table("Prop_PropertyInfo")]
    public class PropPropertyInfoPoco
    {
        [Key]
        public int PropertyId { get; set; }
        public int ClientId { get; set; }
        public int PropertyTypeId { get; set; }
        public int PropertyName { get; set; }
        public string CaptionLine { get; set; }
        public string PropertyAddress { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string ContactNumber { get; set; }
        public string EmailAddress { get; set; }
        public string ContactPerson { get; set; }
        public string ContactPersonJobTitle { get; set; }
        public string ContactPersonPhone { get; set; }
        public string ContactPersonEmail { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreatedBy { get; set; }
    }
}
