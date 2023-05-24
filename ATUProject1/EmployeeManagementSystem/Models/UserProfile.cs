using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace EmployeeManagementSystem.Models
{
    /// <summary>
    /// Represents a user profile.
    /// </summary>
    public class UserProfile
    {
        /// <summary>
        /// Gets or sets the user profile ID.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserProfileId { get; set; }

        /// <summary>
        /// Gets or sets the user ID.
        /// </summary>
        [Required]
        public string? UserId { get; set; }

        /// <summary>
        /// Gets or sets the user associated with the profile.
        /// </summary>
        [ForeignKey("UserId")]
        public virtual IdentityUser User { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        [Required]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        [Required]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the address line 1.
        /// </summary>
        [Required]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Gets or sets the address line 2.
        /// </summary>
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Gets or sets the county.
        /// </summary>
        [Required]
        public string County { get; set; }

        /// <summary>
        /// Gets or sets the Eircode.
        /// </summary>
        [Required]
        public string Eircode { get; set; }

        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        [Required]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the PPSN.
        /// </summary>
        [Required]
        public string PPSN { get; set; }

        /// <summary>
        /// Gets or sets the date of birth.
        /// </summary>
        [Required]
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        [Required]
        public string Gender { get; set; }

        /// <summary>
        /// Gets or sets the yearly salary.
        /// </summary>
        public decimal YearlySalary { get; set; }

        /// <summary>
        /// Gets or sets the tax category.
        /// </summary>
        [Required]
        [Display(Name = "Tax Category")]
        public TaxCategory TaxCategory { get; set; }

        /// <summary>
        /// Gets or sets the number of annual leave days.
        /// </summary>
        public int? AnnualLeaveDays { get; set; }

        /// <summary>
        /// Gets or sets the number of sick leave days.
        /// </summary>
        public int? SickLeaveDays { get; set; }

        /// <summary>
        /// Gets or sets the tax obligation.
        /// </summary>
        public decimal TaxObligation { get; set; }

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        public string? Position { get; set; }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the employee pension contribution percentage.
        /// </summary>
        [Required]
        public decimal EmployeePensionContributionPercentage { get; set; }

        /// <summary>
        /// Gets or sets the employee pension contribution.
        /// </summary>
        public decimal EmployeePensionContribution { get; set; }

        /// <summary>
        /// Gets or sets the employer pension contribution percentage.
        /// </summary>
        [Required]
        public decimal EmployerPensionContributionPercentage { get; set; }

        /// <summary>
        /// Gets or sets the employer pension contribution.
        /// </summary>
        public decimal EmployerPensionContribution { get; set; }

        /// <summary>
        /// Gets or sets the partner's income.
        /// </summary>
        public decimal? PartnerIncome { get; set; }

        /// <summary>
        /// Gets or sets the tax credit.
        /// </summary>
        public decimal TaxCredit { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the profile is complete.
        /// </summary>
        public bool IsProfileComplete { get; set; }

        /// <summary>
        /// Gets the monthly salary based on the yearly salary.
        /// </summary>
        [NotMapped]
        public decimal MonthlySalary => YearlySalary / 12;

        /// <summary>
        /// Gets the weekly salary based on the yearly salary.
        /// </summary>
        [NotMapped]
        public decimal WeeklySalary => YearlySalary / 52;

        /// <summary>
        /// Gets the hourly rate based on the weekly salary (assuming a 40-hour workweek).
        /// </summary>
        [NotMapped]
        public decimal HourlyRate => WeeklySalary / 40;
    }
}



