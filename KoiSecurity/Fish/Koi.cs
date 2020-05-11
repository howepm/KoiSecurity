/* Again, for sure not an easter egg */
using System;
namespace KoiSecurity.Fish
{
    public class Koi : Fish
    {
        public Koi(string name, bool isMale = true) : base(name, "Koi", isMale)
        {
            Console.WriteLine(name + " splashes in the water like the happy Koi they are.");
        }
    }
}
