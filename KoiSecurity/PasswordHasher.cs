using System;

using System.Text;

using KoiSecurity.Math;

namespace KoiSecurity
{
    public class PasswordHasher
    {

        public static string GenerateSalt(int amountRandomNumbers = 16, int amountRandomLetters = 16)
        {
            string middleBit = EasyRandom.RandomLetters(amountRandomNumbers) + "-" + EasyRandom.RandomNumbers().ToString() ;
            middleBit = Jumbler.Jumble(middleBit, 16);
            middleBit = Jumbler.CutStringInHalf(middleBit);

            string randSalt = DateTime.Now.ToString("G").Replace(" ", "-");
            return "KOI-" + randSalt + "-" + middleBit + "-SALT";
        }
        public PasswordHasher()
        {
            Console.WriteLine("You're not really supposed to call PasswordHasher as a new class, it has static methods. So just do using Koiserver.System.Security;, then you can do PasswordHasher.GenerateSalt(32)", "Init", "Error", true);
        }
    }
}
