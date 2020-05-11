using System;
namespace KoiSecurity.Math
{
    public class KoiMath
    {
        public static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }
        public static bool IsEven(int number) { return !IsOdd(number); }
        public static bool IsNotOdd(int number) { return !IsOdd(number); }
        public static bool IsntOdd(int number) { return !IsOdd(number); }
        public static bool IsNotEven(int number) { return IsOdd(number); }
        public static bool IsntEven(int number) { return IsOdd(number); }

        public static int[] GetHalves(int number)
        {
            //this should account for odd and even numbers.... it can look pretty ugly.
            double lowerHalf, upperHalf;

            lowerHalf = Double.Parse((number / 2).ToString());
            upperHalf = Double.Parse((number / 2).ToString());

            int lower, upper;

            lower = int.Parse(System.Math.Floor(lowerHalf).ToString());
            upper = int.Parse(System.Math.Floor(upperHalf).ToString());

            return new int[] { lower, upper };
        }

        public KoiMath()
        {
        }
    }
}
