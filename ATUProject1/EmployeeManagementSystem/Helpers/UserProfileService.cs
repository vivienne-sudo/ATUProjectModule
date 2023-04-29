using EmployeeManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

public class UserProfileService
{
    private readonly ApplicationDbContext _context;

    public UserProfileService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> UserProfileExists(string userId)
    {
        return await _context.UserProfiles.AnyAsync(up => up.UserId == userId);
    }

    // Method that accepts an int parameter
    public async Task<bool> UserProfileExists(int userProfileId)
    {
        return await _context.UserProfiles.AnyAsync(up => up.UserProfileId == userProfileId);
    }

}
