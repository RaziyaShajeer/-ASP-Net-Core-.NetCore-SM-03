using AutoMapper;
using MVC_Auth.Dto;
using MVC_Auth.Interface;
using MVC_Auth.Models;

namespace MVC_Auth.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<bool> RegisterUserAsync(RegisterDto registerDto)
        {
            var existingUser = await _userRepository.GetUserByEmailAsync(registerDto.Email);
            if (existingUser != null)
            {
                return false;
            }

            var user = new User
            {
                Name = registerDto.Name,
                Email = registerDto.Email,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(registerDto.Password), // Hashing Password
                Role = "User"
            };

            await _userRepository.AddUserAsync(user);
            return true;
        }

        public async Task<UseDto> LoginAsync(LoginDto loginDto)
        {
            var user = await _userRepository.GetUserByEmailAsync(loginDto.Email);
            if (user == null || !BCrypt.Net.BCrypt.Verify(loginDto.Password, user.PasswordHash))
            {
                return null;
            }

            return _mapper.Map<UseDto>(user);
        }
    }
}
