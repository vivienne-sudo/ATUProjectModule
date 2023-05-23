using System.ComponentModel.DataAnnotations;
using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Attributes
{
    public class RequiredIfMarriedWithTwoIncomesAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var profileViewModel = (ProfileViewModel)validationContext.ObjectInstance;

            if (profileViewModel.TaxCategory == TaxCategory.MarriedTwoIncomes && (value == null || (decimal)value == 0))
            {
                return new ValidationResult("Partner income is required when the tax category is 'Married with two incomes'.");
            }

            return ValidationResult.Success;
        }
    }
}

