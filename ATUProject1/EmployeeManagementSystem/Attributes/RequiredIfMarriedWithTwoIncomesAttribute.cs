using System.ComponentModel.DataAnnotations;
using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Attributes
{
    /// <summary>
    /// Validates that the partner income is required when the tax category is 'Married with two incomes'.
    /// </summary>
    public class RequiredIfMarriedWithTwoIncomesAttribute : ValidationAttribute
    {
        /// <summary>
        /// Determines whether the specified value is valid.
        /// </summary>
        /// <param name="value">The value to validate.</param>
        /// <param name="validationContext">The context information about the validation operation.</param>
        /// <returns>An instance of the <see cref="ValidationResult"/> class.</returns>
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
