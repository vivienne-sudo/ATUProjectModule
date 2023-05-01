namespace EmployeeManagementSystem.Models
{
    public class SalaryViewModel
    {
        public int UserProfileId { get; set; }

        public decimal GrossYearlySalary { get; set; }
        public decimal NetYearlySalary { get; set; }
        public decimal GrossMonthlySalary { get; set; }
        public decimal NetMonthlySalary { get; set; }
        public decimal GrossWeeklySalary { get; set; }
        public decimal NetWeeklySalary { get; set; }

        public TaxCategory TaxCategory { get; set; }
        public decimal TaxCredit { get; set; }
        public decimal YearlySalary { get; set; }

        public decimal MonthlySalary { get; set; }

        public decimal WeeklySalary { get; set; }

        public decimal HourlyRate { get; set; }

        public decimal TaxObligation { get; set; }

        public decimal EmployeePensionContributionPercentage { get; set; }

        public decimal EmployeePensionContribution { get; set; }

        public decimal EmployerPensionContributionPercentage { get; set; }

        public decimal EmployerPensionContribution { get; set; }

        public decimal? PartnerIncome { get; set; }

    }

}
