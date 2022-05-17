using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampProjectDay5HomeWork5
{
   
        class GamerManager : IGamerService
        {
            IUserValidation _userValidation;

            public GamerManager(IUserValidation userValidation)
            {
                _userValidation = userValidation;
            }

            public void Add(Gamer gamer)
            {
                if (_userValidation.Validate(gamer) == true)
                {
                    Console.WriteLine("Kayıt Başarılı");
                }
                else
                {
                    Console.WriteLine("Kayıt Başarısız.");
                }
            }

            public void Delete(Gamer gamer)
            {
                Console.WriteLine("Kayıt Silindi.");
            }

            public void Update(Gamer gamer)
            {
                Console.WriteLine("Kayıt Güncellendi.");
            }
        }
}
