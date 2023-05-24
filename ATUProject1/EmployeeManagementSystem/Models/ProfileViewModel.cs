using EmployeeManagementSystem.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Models
{
    /// <summary>
    /// Represents the profile view model.
    /// </summary>
    public class ProfileViewModel
    {
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the address line 1.
        /// </summary>
        [Required]
        [Display(Name = "Address Line 1")]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Gets or sets the address line 2.
        /// </summary>
        [Display(Name = "Address Line 2")]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Gets or sets the county.
        /// </summary>
        [Required]
        [Display(Name = "County")]
        public string County { get; set; }

        /// <summary>
        /// Gets or sets the Eircode.
        /// </summary>
        [Required]
        [Display(Name = "Eircode")]
        public string Eircode { get; set; }

        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the PPSN.
        /// </summary>
        [Required]
        [Display(Name = "PPSN")]
        public string PPSN { get; set; }

        /// <summary>
        /// Gets or sets the date of birth.
        /// </summary>
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        [MinimumAge(16)]
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        [Required]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        /// <summary>
        /// Gets or sets the yearly salary.
        /// </summary>
        [Required]
        public decimal YearlySalary { get; set; }

        /// <summary>
        /// Gets or sets the partner income.
        /// </summary>
        [RequiredIfMarriedWithTwoIncomes]
        [Display(Name = "Partner Income")]
        public decimal? PartnerIncome { get; set; }

        /// <summary>
        /// Gets or sets the user profile ID.
        /// </summary>
        public int UserProfileId { get; set; }

        /// <summary>
        /// Gets or sets the user ID.
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the tax category.
        /// </summary>
        [Required]
        [Display(Name = "Tax Category")]
        public TaxCategory TaxCategory { get; set; }
    }

    /// <summary>
    /// Represents the tax category.
    /// </summary>
    public enum TaxCategory
    {
        Single,
        MarriedSingleIncome,
        MarriedTwoIncomes,
        OneParentFamily
    }
}

