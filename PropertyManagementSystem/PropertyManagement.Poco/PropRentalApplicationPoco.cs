using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagement.Poco
{
    [Table("Prop_RentalApplication")]
    public class PropRentalApplicationPoco
    {
        [Key]
        public int ApplicationId { get; set; }
        public int ApplicationNumber { get; set; }
        public int UnitId { get; set; }
        public int PropertyId { get; set; }
        public int UserId { get; set; }
        public int NumberOfOccupant { get; set; }
        public string EmploymentStatus { get; set; }
        public decimal YearlySalaryBeforeTax { get; set; }
        public bool PetFriendlyRequired { get; set; }
        public string ApplicationSource { get; set; }
        public string ApplicationStatus { get; set; } // Approved, rejected etc.
        public int CreditScore { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string RejectionReason { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreatedBy { get; set; }
    }
}
