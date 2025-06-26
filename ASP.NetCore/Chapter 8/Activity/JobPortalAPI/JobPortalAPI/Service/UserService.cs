using AutoMapper;
using JobPortalAPI.DTOs;
using JobPortalAPI.Interface;
using JobPortalAPI.Model;
using JobPortalAPI.Repository;
using System.Security.Cryptography;
using System.Text;

namespace JobPortalAPI.Service
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

        public async Task<UserDTO> RegisterUserAsync(UserRegisterDTO userRegisterDto)
        {
            // Check if user already exists
            var existingUser = await _userRepository.GetUserByEmailAsync(userRegisterDto.Email);
            if (existingUser != null)
                throw new Exception("User with this email already exists.");

            // Hash Password
            var passwordHash = HashPassword(userRegisterDto.Password);

            var user = new User
            {
                Name = userRegisterDto.Name,
                Email = userRegisterDto.Email,
                PasswordHash = passwordHash
            };

            var registeredUser = await _userRepository.RegisterUserAsync(user);
            return _mapper.Map<UserDTO>(registeredUser);
        }

        public async Task<UserDTO> LoginUserAsync(UserLoginDTO userLoginDto)
        {
            var user = await _userRepository.GetUserByEmailAsync(userLoginDto.Email);
            if (user == null || !VerifyPassword(userLoginDto.Password, user.PasswordHash))
                throw new Exception("Invalid email or password.");

            return _mapper.Map<UserDTO>(user);
        }

        public async Task<UserDTO> GetUserByIdAsync(int id)
        {
            var user = await _userRepository.GetUserByIdAsync(id);
            return _mapper.Map<UserDTO>(user);
        }

        private string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();
            var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(hashedBytes);
        }

        private bool VerifyPassword(string enteredPassword, string storedHash)
        {
            return HashPassword(enteredPassword) == storedHash;
        }
    }
}
