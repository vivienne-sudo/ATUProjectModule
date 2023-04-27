using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using VBV3Project.Models;

namespace VBV3Project.Models
{

    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        public bool IsActive { get; set; }

        public DateTime HireDate { get; set; }
    }
}