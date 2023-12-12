using System.Diagnostics;
using System.Security.Cryptography;

namespace GjkEvent.Models.Data
{
    public static class DbInitializer
    {
        public static void Initialize(GjkEventContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
