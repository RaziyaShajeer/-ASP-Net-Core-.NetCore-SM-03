using JobPortalAPI.Model;

namespace JobPortalAPI.Interface
{
    public interface IUserRepository
    {
        Task<User> GetUserByEmailAsync(string email);
        Task<User> RegisterUserAsync(User user);
        Task<User> GetUserByIdAsync(int id);
    }
}
