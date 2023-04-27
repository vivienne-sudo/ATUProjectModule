using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace EmployeeManagementSystem.Models
{
    public class UserProfile
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserProfileId { get; set; }

        [Required]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual IdentityUser User { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        [Required]
        public string County { get; set; }

        [Required]
        public string Eircode { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string PPSN { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string RelationshipStatus { get; set; }

        public decimal YearlySalary { get; set; }

        public decimal TaxObligation { get; set; }

        [Required]
        public decimal EmployeePensionContributionPercentage { get; set; }

        public decimal EmployeePensionContribution { get; set; }

        [Required]
        public decimal EmployerPensionContributionPercentage { get; set; }

        public decimal EmployerPensionContribution { get; set; }
        public decimal? PartnerIncome { get; set; }
        

        // Calculated properties
        [NotMapped]
        public decimal MonthlySalary => YearlySalary / 12;

        [NotMapped]
        public decimal WeeklySalary => YearlySalary / 52;

        [NotMapped]
        public decimal HourlyRate => WeeklySalary / 40; // Assuming a 40-hour workweek
    }
}

