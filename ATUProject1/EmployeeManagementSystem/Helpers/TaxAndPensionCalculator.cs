using EmployeeManagementSystem.Models;


namespace EmployeeManagementSystem.Helpers
{
    /// <summary>
    /// A helper class for calculating tax and pension contributions.
    /// </summary>
    public static class TaxAndPensionCalculator
    {
        /// <summary>
        /// Enumeration representing marital status options.
        /// </summary>
        public enum MaritalStatus
        {
            Single,
            MarriedSingleIncome,
            MarriedTwoIncomes,
            OneParentFamily
        }

        /// <summary>
        /// Calculates the tax amount based on the provided parameters.
        /// </summary>
        /// <param name="yearlySalary">The yearly salary of the employee.</param>
        /// <param name="employeePensionContributionPercentage">The employee's pension contribution percentage.</param>
        /// <param name="taxCredit">The tax credit amount.</param>
        /// <param name="partnerIncome">The income of the partner (applicable for MarriedTwoIncomes category).</param>
        /// <param name="taxCategory">The tax category.</param>
        /// <returns>The calculated tax amount.</returns>
        public static decimal CalculateTax(decimal yearlySalary, decimal employeePensionContributionPercentage, decimal taxCredit, decimal partnerIncome, TaxCategory taxCategory)
        {
            decimal pensionContribution = yearlySalary * (employeePensionContributionPercentage / 100);
            decimal taxableIncome = yearlySalary - pensionContribution;

            if (taxCategory == TaxCategory.MarriedTwoIncomes)
            {
                taxableIncome += partnerIncome;
                taxCredit *= 2;
            }

            decimal totalTax = 0;
            decimal remainingIncome = taxableIncome - taxCredit;

            // Tax brackets
            decimal[] taxBrackets;

            switch (taxCategory)
            {
                case TaxCategory.Single:
                    taxBrackets = new[] { 40000m, remainingIncome };
                    break;
                case TaxCategory.OneParentFamily:
                    taxBrackets = new[] { 44000m, remainingIncome };
                    break;
                case TaxCategory.MarriedSingleIncome:
                    taxBrackets = new[] { 49000m, remainingIncome };
                    break;
                case TaxCategory.MarriedTwoIncomes:
                    decimal lowerBracket = Math.Min(31000m, partnerIncome);
                    taxBrackets = new[] { 49000m + lowerBracket, remainingIncome };
                    break;
                default:
                    throw new ArgumentException("Invalid tax category");
            }

            if (remainingIncome > 0)
            {
                decimal taxedAt20Percent = Math.Min(remainingIncome, taxBrackets[0]);
                totalTax += taxedAt20Percent * 0.20m;
                remainingIncome -= taxedAt20Percent;
            }

            if (remainingIncome > 0)
            {
                totalTax += remainingIncome * 0.40m;
            }

            return totalTax;
        }
    }
}


