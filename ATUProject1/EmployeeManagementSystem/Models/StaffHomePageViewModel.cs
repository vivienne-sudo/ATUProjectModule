namespace EmployeeManagementSystem.Models
{
    /// <summary>
    /// Represents the view model for the staff home page.
    /// </summary>
    public class StaffHomePageViewModel
    {
        /// <summary>
        /// Gets or sets the error message.
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets or sets the user profile.
        /// </summary>
        public UserProfile UserProfile { get; set; }

        /// <summary>
        /// Gets or sets the number of annual leave days.
        /// </summary>
        public int AnnualLeaveDays { get; set; }

        /// <summary>
        /// Gets or sets the number of sick leave days.
        /// </summary>
        public int SickLeaveDays { get; set; }

        /// <summary>
        /// Gets or sets the user profile ID.
        /// </summary>
        public string? UserProfileId { get; set; }

        /// <summary>
        /// Gets or sets the list of bank holidays.
        /// </summary>
        public List<BankHoliday> BankHolidays { get; set; }
    }
}
