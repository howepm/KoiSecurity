/*
 * Habbo uses a modifed version of RC4 Encryption and it slightly
 * altered between versions, especially at V7 and V9, and I
 * believe now they shuffle the table every release and move things
 * around, although I'm not 100%.
 *
 * I am not yet sure what Lumiosta, Mobiles Disco or the Goldfish
 * client use. I am also not 100% what FUSE/Benchmark has built-in
 * encryption wise. I will investigate.
 *
 * I envision I might end up making a FUSE DLL which has this as a
 * dependency, which is exactly what I wanted for the modularity
 * aspect of the server
 * 
*/

using System;
namespace KoiSecurity
{
    public class RC4Encryption
    {
        public RC4Encryption()
        {
            Console.WriteLine("You're not really supposed to call RC4Encryption as a new class, it has static methods. So just do using KoiSecurity;, then you can use it's methods");
        }

        public static string HabboV1Encrypt(string data, string key)
        {
            return "";
        }
        public static string HabboV1Decrypt(string data, string key)
        {
            return "";
        }
        public static string HabboV5Encrypt(string data, string key)
        {
            return "";
        }
        public static string HabboV5Decrypt(string data, string key)
        {
            return "";
        }
        public static string HabboV7Encrypt(string data, string key)
        {
            return "";
        }
        public static string HabboV7Decrypt(string data, string key)
        {
            return "";
        }
        public static string HabboV9Encrypt(string data, string key)
        {
            return "";
        }
        public static string HabboV9Decrypt(string data, string key)
        {
            return "";
        }
    }
}
