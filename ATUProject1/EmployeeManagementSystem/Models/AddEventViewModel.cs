using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Models
{
    public class AddEventViewModel
    {
        [Required]
        public string EventTitle { get; set; }

        [Required]
        public DateTime Start { get; set; }

        public DateTime? End { get; set; }
    }

}
