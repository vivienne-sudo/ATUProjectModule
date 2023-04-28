namespace EmployeeManagementSystem.Helpers
{
    public static class TaxAndPensionCalculator
    {
        public enum MaritalStatus
        {
            Single,
            MarriedSingleIncome,
            MarriedTwoIncomes,
            OneParentFamily
        }

        public static decimal CalculateTax(decimal yearlySalary, decimal taxCredit, decimal partnerIncome, MaritalStatus maritalStatus)
        {
            decimal standardTaxRate = 0.2m; // 20%
            decimal higherTaxRate = 0.4m; // 40%

            decimal taxRateCutOff;

            switch (maritalStatus)
            {
                case MaritalStatus.Single:
                    taxRateCutOff = 35300; // The cut-off point for the 20% tax rate
                    break;
                case MaritalStatus.MarriedSingleIncome:
                    taxRateCutOff = 49000; // The cut-off point for the 20% tax rate
                    break;
                case MaritalStatus.MarriedTwoIncomes:
                    decimal lowerSpouseIncome = Math.Min(yearlySalary, partnerIncome);
                    decimal maxAdditionalCutOff = 31000;
                    taxRateCutOff = 49000 + Math.Min(maxAdditionalCutOff, lowerSpouseIncome);
                    break;
                case MaritalStatus.OneParentFamily:
                    taxRateCutOff = 38300; // The cut-off point for the 20% tax rate
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(maritalStatus), maritalStatus, null);
            }

            decimal taxableIncome = yearlySalary > taxRateCutOff ? taxRateCutOff : yearlySalary;
            decimal higherTaxableIncome = yearlySalary > taxRateCutOff ? yearlySalary - taxRateCutOff : 0;

            decimal tax = (taxableIncome * standardTaxRate) + (higherTaxableIncome * higherTaxRate) - taxCredit;

            return tax;
        }
    }
}

