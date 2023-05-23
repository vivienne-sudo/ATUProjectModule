using EmployeeManagementSystem.Data;
using Microsoft.EntityFrameworkCore;

// <summary>
/// Service class for managing user profiles.
/// </summary>
public class UserProfileService
{
    private readonly ApplicationDbContext _context;

    /// <summary>
    /// Initializes a new instance of the UserProfileService class.
    /// </summary>
    /// <param name="context">The application database context.</param>
    public UserProfileService(ApplicationDbContext context)
    {
        _context = context;
    }


    /// <summary>
    /// Checks if a user profile exists for the specified user ID.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <returns>True if the user profile exists; otherwise, false.</returns>
    public async Task<bool> UserProfileExists(string userId)
    {
        return await _context.UserProfiles.AnyAsync(up => up.UserId == userId);
    }


    /// <summary>
    /// Checks if a user profile exists for the specified user profile ID.
    /// </summary>
    /// <param name="userProfileId">The ID of the user profile.</param>
    /// <returns>True if the user profile exists; otherwise, false.</returns>
    public async Task<bool> UserProfileExists(int userProfileId)
    {
        return await _context.UserProfiles.AnyAsync(up => up.UserProfileId == userProfileId);
    }

}
