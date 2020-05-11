using System;

using KoiSecurity.Math;

namespace KoiSecurity
{
    public class Key
    {
        public static string GenerateUUIDKey()
        {
            return UUID.GenerateUUID();
        }
        public static string GeneratePassSaltKey()
        {
            return PasswordHasher.GenerateSalt();
        }
        public static string GenerateRandomTextKey(int length = 128, bool uppercase = false)
        {
            return EasyRandom.RandomLetters(length, uppercase);
        }
        public static string GenerateRandomNumberKey(int length = 128)
        {
            return EasyRandom.RandomNumbers(length).ToString();
        }
        public static string GenerateRandomKey(int length = 64)
        {
            return EasyRandom.RandomLettersAndNumbers(length);
        }

        public static string GenerateAuthenticKey()
        {
            return "";
        }

        public Key()
        {
        }
    }
}
