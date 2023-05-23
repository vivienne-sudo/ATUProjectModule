using System.Collections.Generic;
using System.Threading.Tasks;
using V2VB.Model;

namespace V2VB.Services
{
    public interface IUserService
    {
        Task<User> GetUserAsync(int id);
        Task<User> GetUserByEmailAsync(string email);
        Task<List<User>> GetAllUsersAsync();
        Task CreateUserAsync(User user);
        Task UpdateUserAsync(User user);
        Task DeleteUserAsync(User user);
        Task<bool> AuthenticateAsync(string email, string password);
        Task ResetPasswordAsync(string email, string newPassword);
    }
}
