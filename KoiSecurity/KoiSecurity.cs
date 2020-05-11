using System;

using System.IO;

using KoiSecurity.Fish;

namespace KoiSecurity
{
    public class KoiSecurity
    {
        /* This is basically a readme built into the library! */
        public KoiSecurity() { About(); }
        public static void About()
        {
            Console.Clear();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~**");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~**");
            Console.WriteLine("**                                                                           **");
            Console.WriteLine("**            __ __      _ _____                      _ __                   **");
            Console.WriteLine("**           / //_/___  (_) ___/___  _______  _______(_) /___  __            **");
            Console.WriteLine("**           / ,< / __ \\/ /\\__ \\/ _ \\/ ___/ / / / ___/ / __/ / / /           **");
            Console.WriteLine("**          / /| / /_/ / /___/ /  __/ /__/ /_/ / /  / / /_/ /_/ /            **");
            Console.WriteLine("**          /_/ |_\\____/_//____/\\___/\\___/\\__,_/_/  /_/\\__/\\__, /            **");
            Console.WriteLine("**                                                      /____/               **");
            Console.WriteLine("**                                                                           **");
            Console.WriteLine("**                                               by Alexander Howe / Howe.PM **");
            Console.WriteLine("**                                                              Version: 0.1 **");
            Console.WriteLine("**~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~**");
            Console.WriteLine("**~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~**");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~**");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~**");
            Console.WriteLine("**                                                                           **");
            Console.WriteLine("**               And maybe a little fishy minigame/easter egg...             **");
            Console.WriteLine("**                                                                           **");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~**");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~**");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("--------------------------------------------------<{[KoiSecurity | Author]}>----");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("*  Created by Alex Howe. See http://howe.pm/projects/KoiSecurity or my GitHub  *");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("-------------------------------------------------<{[KoiSecurity | License]}>----");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("*  This is released under the DWTFYL license - do what the fuck you like with  *");
            Console.WriteLine("* it. I'd like credit in the form of a link to Howe.PM, but you don't have to. *");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("*                                    Enjoy!                                    *");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("----------------------------------------------------<{[KoiSecurity | Info]}>----");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("*   KoiSecruty is a small C# library containing a couple of security related   *");
            Console.WriteLine("* features that were originally used for a project of mine that of the time of *");
            Console.WriteLine("*  writing is unreleased - KoiServer. These are functions I often find myself  *");
            Console.WriteLine("*  rewriting (admittedly, because I've dropped the concept of KoiServer many   *");
            Console.WriteLine("*  times over the years) but I think I will find them useful in other net and  *");
            Console.WriteLine("*                gameserver projects, plus who knows what else.                *");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("* Plus, I have not ever really made libraries outside PHP and I plan on making *");
            Console.WriteLine("*  a few more libraries of common functions I've made over the years, also if  *");
            Console.WriteLine("*  appropriate, I may make parts of the server itself a library as I plan on   *");
            Console.WriteLine("*  supporting multiple client versions PLUS a few auxiliary games that use the *");
            Console.WriteLine("* same protocol. I'm being vague, but people online who know me know the games *");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("-----------------------------------------------------------<{[KoiSecurity]}>----");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("I'm going to give you your own fish. What would you like to call it?");
            string readName = Console.ReadLine();
            Console.WriteLine("What gender would you like it to be? Anything starting with 'b' (boy) or 'm' (male/man) will be male, any other options will be read as female.");
            string readGender = Console.ReadLine();
            bool isMale;
            if(readGender[0] == "b".ToCharArray()[0] | readGender[0] == "m".ToCharArray()[0])
            {
                isMale = true;
                Console.WriteLine("Ah, a male fish. Cool.");
            }
            else
            {
                isMale = false;
                Console.WriteLine("A female fish, eh?");
            }
            
            Console.WriteLine("What species of fish would you like? I suggest Koi");
            string readSpecies = Console.ReadLine();
            if(readSpecies.ToLower() != "koi")
            {
                Console.WriteLine("You want a " + readSpecies + "?! This is KoiSecruity. You're getting a Koi.");
            }
            Console.WriteLine("OK, we're contacting the stawk now.");
            Koi newFish = new Koi(readName, isMale);
            int count = 0;
            bool doLoop = true;
            string userInput;
            while(doLoop)
            {
                Console.WriteLine("You've made " + readName + " do " + count + " actions.");
                Console.WriteLine("What would you like them to do next?");
                if(count == 10) { Console.WriteLine("Psst... Don't tell PETA, but if you type die, it'll end all this."); }

                if (count == 20) { newFish.Do("is very shellfish and just stole your snack."); }
                if (count == 50) { newFish.Do("started school."); }
                if (count == 375) { newFish.Do("finished school. It didn't go great, they're a fish."); }
                if (count == 500) { newFish.Do("entered middle age."); }
                if (count == 750) { newFish.Do("just started collecting a pension."); }

                if (count == 1000)
                {
                    newFish.Do("died of old age at the ripe old age of 1000 cycles. Why did you keep this going for so long?");
                    Console.ReadLine();
                    doLoop = false;
                    break;
                }

                userInput = Console.ReadLine();
                if(userInput.ToLower() == "die" | userInput.ToLower() == "kill" | userInput.ToLower() == "hurt" | userInput.ToLower() == "quit" | userInput.ToLower() == "exit" | userInput.ToLower() == "escape")
                {
                    if(userInput.ToLower() == "escape")
                    {
                        newFish.Do("sprouted legs and lungs and escaped somehow!");
                    }
                    else
                    {
                        newFish.Do("died. Just plain ol' died.");
                    }
                    doLoop = false;
                    break;
                }
                else
                {
                    newFish.Do(userInput);
                }

                count = count + 1;
            }
        }
    }
}
