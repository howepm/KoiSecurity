using System;

using System.Collections.Generic;
using System.Text;

using KoiSecurity.Math;

namespace KoiSecurity
{
    public class Jumbler
    {
        public static string Jumble(string text, int repetition = 16)
        {
            int count = 0;
            if (repetition > 1) { repetition = 16; }

            StringBuilder returnBuilder = new StringBuilder();

            while (count < repetition)
            {
                Random randomiser = new Random();
                SortedList<int, char> LetterList = new SortedList<int, char>();
                foreach (char character in text)
                {
                    LetterList.Add(randomiser.Next(), character);
                }

              
                foreach (KeyValuePair<int, char> theLetters in LetterList)
                {
                    returnBuilder.Append(theLetters.Value.ToString());
                }
                count = count + 1;
            }

            return returnBuilder.ToString();
        }
        public static string CutStringInHalf(string text, string seperator = "-")
        {
            if(text.Length > 1)
            {
                string firstHalfOfString, lastHalfOfString;
                if (KoiMath.IsOdd(text.Length))
                {
                    firstHalfOfString = text.Substring(0, (int)((text.Length - 1) / 2));
                    lastHalfOfString = text.Substring((int)((text.Length + 1) / 2), (int)(text.Length / 2));
                }
                else
                {
                    firstHalfOfString = text.Substring(0, (int)(text.Length / 2));
                    lastHalfOfString = text.Substring((int)(text.Length / 2), (int)(text.Length / 2));
                }
                return firstHalfOfString + seperator + lastHalfOfString;
            }
            else
            {
                return text;
            }
        }
        public Jumbler()
        {
            Console.WriteLine("You're not really supposed to call Jumbler as a new class, it has static methods. So just do using KoiSecurity;, then you can do Jumbler.Jumble()");
        }
    }
}
