using System.Diagnostics;
using System.Security.Cryptography;

namespace GjkEvent.Models.Data
{
    public static class DbInitializer
    {
        public static void Initialize(GjkEventContext context)
        {
            context.Database.EnsureCreated();

            if (context.Users.Any())
            {
                return;
            }

            var Users = new User[]
            {
            new User{Username="Carson",Password="Alexander", QrCode=RandomStringGenerator.RandomString(16)},
            new User{Username="Meredith",Password="Alonso", QrCode=RandomStringGenerator.RandomString(16)},
            new User{Username="Arturo",Password="Anand", QrCode=RandomStringGenerator.RandomString(16)},
            new User{Username="Gytis",Password="Barzdukas", QrCode=RandomStringGenerator.RandomString(16)},
            new User{Username="Yan",Password="Li", QrCode=RandomStringGenerator.RandomString(16)},
            new User{Username="Peggy",Password="Justice", QrCode=RandomStringGenerator.RandomString(16)},
            new User{Username="Laura",Password="Norman", QrCode=RandomStringGenerator.RandomString(16)},
            new User{Username="Nino",Password="Olivetto", QrCode=RandomStringGenerator.RandomString(16)}
            };
            foreach (User s in Users)
            {
                context.Users.Add(s);
            }
            context.SaveChanges();
        }
    }
}
