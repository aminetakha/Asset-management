using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Patrimoine.Dto
{
    public class UserLoginResponseDto
    {
        public bool DoesExist { get; set; }
        public UserDto User { get; set; }

        public UserLoginResponseDto(bool exist, UserDto user)
        {
            DoesExist = exist;
            User = user;
        }

    }
}
