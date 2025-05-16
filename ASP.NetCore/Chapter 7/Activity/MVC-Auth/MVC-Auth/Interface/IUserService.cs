using MVC_Auth.Dto;

namespace MVC_Auth.Interface
{
    public interface IUserService
    {
        Task<bool> RegisterUserAsync(RegisterDto registerDto);
        Task<UseDto> LoginAsync(LoginDto loginDto);
    }
}
