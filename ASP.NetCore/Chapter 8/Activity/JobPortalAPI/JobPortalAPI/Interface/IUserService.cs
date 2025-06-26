using JobPortalAPI.DTOs;

namespace JobPortalAPI.Interface
{
    public interface IUserService
    {
        Task<UserDTO> RegisterUserAsync(UserRegisterDTO userRegisterDto);
        Task<UserDTO> LoginUserAsync(UserLoginDTO userLoginDto);
        Task<UserDTO> GetUserByIdAsync(int id);
    }
}
