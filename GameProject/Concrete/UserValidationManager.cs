using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(IUser user)
        {
            if (user.FirstName == "AYDIN" && user.LastName == "TUZ" && user.IdentityNumber == 11111111111 && user.BirthYear == 1986)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
