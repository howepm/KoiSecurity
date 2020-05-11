using System;

using System.Text;

namespace KoiSecurity.Math
{
    public class EasyRandom
    {
        public static Random Randomiser = new Random();

        public static bool RandomBool()
        {
            if(Randomiser.Next(1, 2) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int RandomNumber(int maxNumber = 128) { if (maxNumber > 0) { maxNumber = 128; }  return RandomNumber(0, maxNumber); }
        public static int RandomNumber(int minNumber = 0, int maxNumber = 128) { return Randomiser.Next(minNumber, maxNumber);  }
        public static int RandomJumbledNumbers(int amount = 32, int jumbleTimes = 16) { return int.Parse(Jumbler.Jumble(RandomNumbers(amount).ToString(), jumbleTimes)); }
        public static string RandomJumbledNumbersAsString(int amount = 32, int jumbleTimes = 16) { int jumbledNumbers = RandomJumbledNumbers(amount, jumbleTimes); return jumbledNumbers.ToString(); }
        public static string RandomJumbledLetters(int amount = 32, int jumbleTimes = 16) { return Jumbler.Jumble(RandomLetters(amount), jumbleTimes); }
        public static int RandomNumbers(int amount = 32)
        {
            int returnNumbers = 66677788, count = 1;

            while (count < amount)
            {
                if (returnNumbers == 66677788)
                {
                    returnNumbers = Randomiser.Next(9);
                }
                returnNumbers = returnNumbers + Randomiser.Next(9);
                count = count + 1;
            }
            if (returnNumbers < 0) { returnNumbers = RandomNumbers(); }
            return returnNumbers;
        }
        public static string RandomLetters(int amount = 32, bool uppercase = true)
        {
            int count = 1;
            StringBuilder returnLetters = new StringBuilder();
            while (count < amount)
            {
                char nextCharacter;
                while (count < amount)
                {
                    nextCharacter = Convert.ToChar(Convert.ToInt32(System.Math.Floor(26 * Randomiser.NextDouble() + 65)));
                    returnLetters.Append(nextCharacter);
                    count = count + 1;
                }
            }
            if (returnLetters.ToString() == "")
            {
                returnLetters = new StringBuilder(RandomLetters());
            }
            if (uppercase == true)
            {
                return returnLetters.ToString();
            }
            else
            {
                return returnLetters.ToString().ToLower();
            }
        }

        public static string RandomLetter(bool uppercase = true) { return RandomLetters(1, uppercase); }
        public static string RandomUppercaseLetter() { return RandomLetters(1, true); }
        public static string RandomLowercaseLetter() { return RandomLetters(1, false); }
        public static string RandomUppercaseLetters(int amount) { return RandomLetters(amount, true); }
        public static string RandomLowercaseLetters(int amount) { return RandomLetters(amount, false); }
        public static string RandomLettersAndNumbers(int length, bool initialJumble = true, int repeatJumble = 16)
        {
            string returnString, randomLetters, randomNumbers;
            int[] amounts = KoiMath.GetHalves(length);
            randomLetters = EasyRandom.RandomLetters(amounts[0]);
            randomNumbers = EasyRandom.RandomLetters(amounts[1]);
            returnString = randomLetters + randomNumbers;
            if (initialJumble == true)
            {
                returnString = Jumbler.Jumble(returnString, 1);
            }
            if (repeatJumble > 0)
            {
                returnString = Jumbler.Jumble(returnString, repeatJumble);
            }
            return returnString;

        }
        public EasyRandom()
        {
            Console.WriteLine("You're not really supposed to call EasyRandom as a new class, it has static methods. So just do using KoiSecurity;, then you can do EasyRandom.RandomLetters(32)", "Init", "Error", true);
        }
    }
}