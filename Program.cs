using System;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace Hello_World
{
    class Program
    {
        private static int SyllableCount(string word)
        {
            word = word.ToLower().Trim();
            bool lastWasVowel = true;
            var vowels = new[] { 'a', 'e', 'i', 'o', 'u', 'y' };
            int count = 0;

            //a string is an IEnumerable<char>; convenient.
            foreach (var l in word)
            {
                if (vowels.Contains(l))
                {
                    if (!lastWasVowel)
                        count++;
                    lastWasVowel = true;
                }
                else
                    lastWasVowel = false;
            }

            if ((word.EndsWith("e") || (word.EndsWith("es") || word.EndsWith("ed")))
                  && !word.EndsWith("le"))
                count--;

            return count;
        }
        static void Main(string[] args)
        {

            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan", "Cat" };
            foreach (var animal in animals)
            {
                var syllableCount = SyllableCount(animal);
                if (syllableCount >= 2)
                {
                    Console.WriteLine(animal);
                }
                else
                {
                    Console.WriteLine("No animals found");
                }
            }



            string response;
            var southern = "Howdy Y'all";
            var northern = "What's up?";
            var jersey = "How you doing?";
            Console.WriteLine("Pick a greeting -- northern, southern or jersey");
            response = Console.ReadLine();


            if (response == "southern")
            {
                Console.WriteLine(southern);
            }
            else if (response == "northern")
            {
                Console.WriteLine(northern);
            }
            else if (response == "jersey")
            {
                Console.WriteLine(jersey);

            }
        }
    }
}










