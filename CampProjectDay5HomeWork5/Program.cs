using System;

namespace CampProjectDay5HomeWork5
{
    class Program
    {
       
            static void Main(string[] args)
            {
                GamerManager gamerManager = new GamerManager(new UserValidation());
                gamerManager.Add(new Gamer
                {
                    Id = 123,
                    FirstName = "Kübranur",
                    LastName = "Şahin",
                    IdentityNumber = 61312222818
                });

            }
        
    }
}
