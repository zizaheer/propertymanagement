using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagement.Poco
{
    [Table("Prop_Enquiry")]
    public class PropEnquiryPoco
    {
        [Key]
        public int EnquiryId { get; set; }
        public int EnquiryTypeId { get; set; }
        public int UnitId { get; set; }
        public int PropertyId { get; set; }
        public string EnquirerFirstName { get; set; }
        public string EnquirerLastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string EnquiryDetails { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreateDate { get; set; }
        public int CreatedBy { get; set; }
    }
}
