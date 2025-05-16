using MVC_Auth.Models;

namespace MVC_Auth.Interface
{
    public interface IUserRepository
    {
        Task<User> GetUserByEmailAsync(string email);
        Task AddUserAsync(User user);
    }
}
