using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace VBV3Project.Models
{
    public class User : IdentityUser
    {
        public bool IsEmailVerified { get; set; }
        public ICollection<Employee> Employees { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        [StringLength(100)]
        public string BusinessName { get; set; }

        [Required]
        [StringLength(255)]
        public string BusinessAddress { get; set; }

        [Required]
        [StringLength(100)]
        public string Eircode { get; set; }

        public string BusinessDescription { get; set; }
}

public enum UserRole
    {
        BusinessOwner,
        Employee
    }

}
