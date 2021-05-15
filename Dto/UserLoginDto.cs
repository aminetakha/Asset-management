using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Patrimoine.Dto
{
    public class UserLoginDto
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public UserLoginDto(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}
