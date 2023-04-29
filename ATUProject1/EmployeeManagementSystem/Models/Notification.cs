using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Models
{
    public class Notification
    {
        public int Id { get; set; }

        [Required]
        public string AdminId { get; set; }

        [Required]
        public string StaffUserId { get; set; }

        [Required]
        public string Message { get; set; }

        public bool IsViewed { get; set; }

        public DateTime Timestamp { get; set; }
    }
}

