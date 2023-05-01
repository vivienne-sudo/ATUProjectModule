using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Models
{
    public class EditSalaryViewModel
    {
        public int UserProfileId { get; set; }
        public decimal YearlySalary { get; set; }

        [Display(Name = "Position")]
        public string Position { get; set; }

        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Display(Name = "Employer Pension Contribution Percentage")]
        public decimal EmployerPensionContributionPercentage { get; set; }
    }

}
