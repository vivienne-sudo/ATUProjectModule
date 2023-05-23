using System.ComponentModel.DataAnnotations;

/// <summary>
/// Validates that the specified value represents a minimum age.
/// </summary>
public class MinimumAgeAttribute : ValidationAttribute
{
    private readonly int _minimumAge;

    /// <summary>
    /// Initializes a new instance of the <see cref="MinimumAgeAttribute"/> class with the specified minimum age.
    /// </summary>
    /// <param name="minimumAge">The minimum age value.</param>
    public MinimumAgeAttribute(int minimumAge)
    {
        _minimumAge = minimumAge;
    }

    /// <summary>
    /// Determines whether the specified value is valid.
    /// </summary>
    /// <param name="value">The value to validate.</param>
    /// <param name="validationContext">The context information about the validation operation.</param>
    /// <returns>An instance of the <see cref="ValidationResult"/> class.</returns>
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

