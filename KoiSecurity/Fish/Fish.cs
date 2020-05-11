/* An easter egg? No, of course not... */

using System;

using KoiSecurity.Math;

namespace KoiSecurity.Fish
{
    public class Fish
    {
        private string Name;
        private string Species;

        private enum Gender { MALE, FEMALE };
        Gender MyGender;

        public Fish(string name, string species = "Goldfish", bool isMale = true)
        {
            Name = name;
            Species = species;

            if(isMale)
            {
                MyGender = Gender.MALE;
                Say(Name + " is a very good boy. They are a \"" + Species + "\" fish.");
            }
            else
            {
                MyGender = Gender.FEMALE;
                Say(Name + " is a very good girl. They are a \"" + Species + "\" fish.");
            }
        }

        public void Say(string text)
        {
            Console.WriteLine("[" + Name + "] *blub blub* " + text.Replace("l", "w") + " *blub, blub*");
        }
        public void Do(string job)
        {
            int chance = EasyRandom.RandomNumber(100);
            if (chance > 90) { Breed(); }
            else if (chance > 70) { Say("A fish speaking... how odd.."); }
            else if (chance > 50) {
                string[] foods = new string[] { "Kelp", "Fish Food", "Coral", "Whale Carcus", "Pebbles", "Micro plastics", "Pollutants"};
                int chosenFood = EasyRandom.RandomNumber(0, (foods.Length - 1));
                Eat(foods[chosenFood]);
            }
            else if (chance > 15) { Swim(EasyRandom.RandomNumber(128)); }

            Console.WriteLine(Name + " just " + job);
        }

        public void Swim(double lengthInMeters = 0.5) { Do("swam " + lengthInMeters.ToString() + " meters"); }
        public void Swim(int lengthInMeters) { Swim((double)lengthInMeters); }

        public void Eat(string food) { Do("ate some " + food + ". Nom nom!"); }

        public void Breed()
        {
            if(MyGender == Gender.MALE)
            {
                Do("fertilised some eggs.");
            }
            else
            {
                Do("laid some eggs.");
            }
        }
    }
}
