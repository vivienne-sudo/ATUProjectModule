
namespace EmployeeManagementSystem.Models
{
    /// <summary>
    /// Represents the view model for the admin home page.
    /// </summary>
    public class AdminHomePageViewModel
    {
        /// <summary>
        /// Gets or sets the user profile ID.
        /// </summary>
        public string UserProfileId { get; set; }

        /// <summary>
        /// Gets or sets the list of bank holidays.
        /// </summary>
        public List<BankHoliday> BankHolidays { get; set; }

        /// <summary>
        /// Gets or sets the list of notifications.
        /// </summary>
        public List<Notification> Notifications { get; set; }

        /// <summary>
        /// Initializes a new instance of the AdminHomePageViewModel class.
        /// </summary>
        public AdminHomePageViewModel()
        {
            BankHolidays = new List<BankHoliday>();
            Notifications = new List<Notification>();
        }
    }


}
