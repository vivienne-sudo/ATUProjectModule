using System.ComponentModel.DataAnnotations;
using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Attributes
{

    public class RequiredIfMarriedAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var profileViewModel = (ProfileViewModel)validationContext.ObjectInstance;

            if (profileViewModel.RelationshipStatus == "Married" && (value == null || (decimal)value == 0))
            {
                return new ValidationResult("Partner income is required when the relationship status is 'Married'.");
            }

            return ValidationResult.Success;
        }
    }
}

