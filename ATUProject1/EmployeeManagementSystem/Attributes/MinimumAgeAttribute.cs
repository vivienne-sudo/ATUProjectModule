using System.ComponentModel.DataAnnotations;

public class MinimumAgeAttribute : ValidationAttribute
{
    private readonly int _minimumAge;

    public MinimumAgeAttribute(int minimumAge)
    {
        _minimumAge = minimumAge;
    }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value is DateTime dateOfBirth)
        {
            var today = DateTime.Today;
            var age = today.Year - dateOfBirth.Year;
            if (dateOfBirth.AddYears(age) > today)
            {
                age--;
            }

            if (age >= _minimumAge)
            {
                return ValidationResult.Success;
            }
        }

        return new ValidationResult($"Age must be at least {_minimumAge} years.");
    }
}

