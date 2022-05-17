using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampProjectDay5HomeWork5
{
    class UserValidation : IUserValidation
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Id == 123 && gamer.FirstName == "Kübranur"
                && gamer.LastName == "Şahin"
                && gamer.IdentityNumber == 61312222818)
            {
                return true;
            }

        }
    }
}
