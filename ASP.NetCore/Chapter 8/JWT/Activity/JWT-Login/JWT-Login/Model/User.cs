﻿using JWT_Login.Enum;

namespace JWT_Login.Model
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
        public int IsActive { get; set; } = 1;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}
