using Microsoft.AspNetCore.Identity;

namespace VBV3Project.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string UserRole { get; set; }
        // Add any additional properties you need here
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsEmailVerified { get; set; }
    }
}
