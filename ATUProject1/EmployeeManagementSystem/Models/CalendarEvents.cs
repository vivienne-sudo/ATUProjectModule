using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagementSystem.Models
{
    public class CalendarEvents
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EventId { get; set; }

        [Required]
        public string EventTitle { get; set; }

        [Required]
        public DateTime Start { get; set; }

        public DateTime? End { get; set; }

        // Add the UserProfile navigation property
        public UserProfile UserProfile { get; set; }

        // Change the UserId property type to int
        [ForeignKey("UserProfile")]
        public int UserProfileId { get; set; }
    }
}
