using System;

using System.Text;

using KoiSecurity.Math;

namespace KoiSecurity
{
    public class UUID
    {
        public static string GenerateUUID(int numberOfSections = 8, int sectionLength = 8, bool lettersOnly = false, bool numbersOnly = false, int jumbleRepition = 16, bool addDateTime = true, bool lowercase = false, string seperator = "-")
        {
            
            int count = 1;

            if(numberOfSections < 1) { numberOfSections = 8; }
            if(sectionLength < 1) { sectionLength = 8; }
            if(jumbleRepition < 1) { jumbleRepition = 16;  }

            StringBuilder returnBuilder = new StringBuilder();

            int numberOfNumbers, numberOfLetters;
            

            while(count < numberOfSections)
            {
                if(lettersOnly == true)
                {
                    numberOfLetters = sectionLength;
                    numberOfNumbers = 0;
                }
                else if(numbersOnly == true)
                {
                    numberOfNumbers = sectionLength;
                    numberOfLetters = 0;
                }
                if(KoiMath.IsEven(sectionLength))
                {
                    numberOfNumbers = sectionLength / 2;
                    numberOfLetters = sectionLength / 2;
                }
                else
                {
                    numberOfNumbers = (sectionLength - 1) / 2;
                    numberOfLetters = (sectionLength + 1) / 2;
                }
                if(count != 1) { returnBuilder.Append(seperator);  }
                string returnSection = EasyRandom.RandomLetters(numberOfLetters, !lowercase) + EasyRandom.RandomNumbers(numberOfNumbers).ToString();
                returnSection = Jumbler.Jumble(returnSection, jumbleRepition);
                returnBuilder.Append(returnSection);
            }

            string returnText;
            if (addDateTime == true)
            {
                returnText = "KOI" + seperator + returnBuilder.ToString() + DateTime.Now.ToString().Replace(" ", seperator).Replace("/", seperator).Replace(":", seperator);
            }
            else
            {
                returnText = "KOI" + seperator + returnBuilder.ToString();
            }

            return returnText;
        }
        public UUID()
        {
        }
    }
}
