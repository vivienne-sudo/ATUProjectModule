using EmployeeManagementSystem.Attributes;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Models
{
    public class ProfileViewModel
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Address Line 1")]
        public string AddressLine1 { get; set; }

        [Display(Name = "Address Line 2")]
        public string AddressLine2 { get; set; }

        [Required]
        [Display(Name = "County")]
        public string County { get; set; }

        [Required]
        [Display(Name = "Eircode")]
        public string Eircode { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "PPSN")]
        public string PPSN { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        [MinimumAge(16)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required]
        public decimal YearlySalary { get; set; }

        [RequiredIfMarriedWithTwoIncomes]
        [Display(Name = "Partner Income")]
        public decimal? PartnerIncome { get; set; }
        public int UserProfileId { get; set; }
        public string UserId { get; set; }

        [Required]
        [Display(Name = "Tax Category")]
        public TaxCategory TaxCategory { get; set; }
    }

        public enum TaxCategory
        {
            Single,
            MarriedSingleIncome,
            MarriedTwoIncomes,
            OneParentFamily
        }
   
}


