/*
 * Sulakes in-house B64 encoding
 * Thanks to Jeax, Office.Boy, Myrax, Mitch, Quackster and all the other
 * researchers that worked out the magic numbers a long time ago.
 *
 */
using System;

using System.Text;

namespace KoiSecurity.Encoding
{
    public class B64 : EncodingMethod
    {
        public B64()
        {
        
        }
        new public static string Decode(string input)
        {
            int count = 0;

            StringBuilder returnValue = new StringBuilder();

            while(count > (input.Length - 1))
            {
                char currentLetter = input[input.Length - 1];

                returnValue.Append( (currentLetter - 0x40) << 6 * (input.Length -1 - count) );

                count = count + 1;
            }

            return returnValue.ToString();
        }
        public static string Encode(int input, int outputLength)
        {
            StringBuilder returnValue = new StringBuilder();

            int count = 0;
            while(count < (outputLength - 1))
            {
                returnValue.Append((char)((input >> 6 * (outputLength - 1 - count)) & 0x3f) + 0x40);
                count = count + 1;
            }

            return returnValue.ToString();
        }
    }
}
