namespace EmployeeManagementSystem.Models
{
    /// <summary>
    /// Represents the salary view model.
    /// </summary>
    public class SalaryViewModel
    {
        /// <summary>
        /// Gets or sets the user profile ID.
        /// </summary>
        public int UserProfileId { get; set; }

        /// <summary>
        /// Gets or sets the gross yearly salary.
        /// </summary>
        public decimal GrossYearlySalary { get; set; }

        /// <summary>
        /// Gets or sets the net yearly salary.
        /// </summary>
        public decimal NetYearlySalary { get; set; }

        /// <summary>
        /// Gets or sets the gross monthly salary.
        /// </summary>
        public decimal GrossMonthlySalary { get; set; }

        /// <summary>
        /// Gets or sets the net monthly salary.
        /// </summary>
        public decimal NetMonthlySalary { get; set; }

        /// <summary>
        /// Gets or sets the gross weekly salary.
        /// </summary>
        public decimal GrossWeeklySalary { get; set; }

        /// <summary>
        /// Gets or sets the net weekly salary.
        /// </summary>
        public decimal NetWeeklySalary { get; set; }

        /// <summary>
        /// Gets or sets the tax category.
        /// </summary>
        public TaxCategory TaxCategory { get; set; }

        /// <summary>
        /// Gets or sets the tax credit.
        /// </summary>
        public decimal TaxCredit { get; set; }

        /// <summary>
        /// Gets or sets the tax liability.
        /// </summary>
        public decimal TaxLiability { get; set; }

        /// <summary>
        /// Gets or sets the employee pension contribution percentage.
        /// </summary>
        public decimal EmployeePensionContributionPercentage { get; set; }

        /// <summary>
        /// Gets or sets the employee pension contribution.
        /// </summary>
        public decimal EmployeePensionContribution { get; set; }

        /// <summary>
        /// Gets or sets the employer pension contribution percentage.
        /// </summary>
        public decimal EmployerPensionContributionPercentage { get; set; }

        /// <summary>
        /// Gets or sets the employer pension contribution.
        /// </summary>
        public decimal EmployerPensionContribution { get; set; }

        /// <summary>
        /// Gets or sets the partner income.
        /// </summary>
        public decimal? PartnerIncome { get; set; }
    }
}
