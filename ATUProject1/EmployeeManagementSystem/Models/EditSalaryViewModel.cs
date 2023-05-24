using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Models
{
    /// <summary>
    /// Represents the view model for editing salary information.
    /// </summary>
    public class EditSalaryViewModel
    {
        /// <summary>
        /// Gets or sets the user profile ID.
        /// </summary>
        public int UserProfileId { get; set; }

        /// <summary>
        /// Gets or sets the yearly salary.
        /// </summary>
        public decimal YearlySalary { get; set; }

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        [Display(Name = "Position")]
        public string Position { get; set; }

        /// <summary>
        /// Gets or sets the number of annual leave days.
        /// </summary>
        [Required]
        public int AnnualLeaveDays { get; set; }

        /// <summary>
        /// Gets or sets the number of sick leave days.
        /// </summary>
        [Required]
        public int SickLeaveDays { get; set; }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the employer pension contribution percentage.
        /// </summary>
        [Display(Name = "Employer Pension Contribution Percentage")]
        public decimal EmployerPensionContributionPercentage { get; set; }
    }
}
