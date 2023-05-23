using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Models
{
    /// <summary>
    /// Represents a notification.
    /// </summary>
    public class Notification
    {
        /// <summary>
        /// Gets or sets the notification ID.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the ID of the admin user associated with the notification.
        /// </summary>
        [Required]
        public string AdminId { get; set; }

        /// <summary>
        /// Gets or sets the ID of the staff user associated with the notification.
        /// </summary>
        [Required]
        public string StaffUserId { get; set; }

        /// <summary>
        /// Gets or sets the message of the notification.
        /// </summary>
        [Required]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the notification has been viewed.
        /// </summary>
        public bool IsViewed { get; set; }

        /// <summary>
        /// Gets or sets the timestamp of the notification.
        /// </summary>
        public DateTime Timestamp { get; set; }
    }
}
