using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
       This program is a mad libs game.
       Author: Frederick Safyanov
       */


            // Let the user know that the program is starting:
            Console.WriteLine("The game is about to begin.");

            // Give the Mad Lib a title:
            string title = "MAD LIBS";

            Console.WriteLine(title);
            // Define user input and variables:
            Console.WriteLine("Enter a name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter an adjective: ");
            string firstAdj = Console.ReadLine();

            Console.WriteLine("Enter another adjective: ");
            string secondAdj = Console.ReadLine();

            Console.WriteLine("Enter one more adjective: ");
            string thirdAdj = Console.ReadLine();

            Console.WriteLine("Enter a verb: ");
            string verb = Console.ReadLine();

            Console.WriteLine("Enter a noun: ");
            string firstNoun = Console.ReadLine();

            Console.WriteLine("Enter another noun: ");
            string secondNoun = Console.ReadLine();

            Console.WriteLine("Enter an animal: ");
            string animal = Console.ReadLine();

            Console.WriteLine("Enter a food: ");
            string food = Console.ReadLine();

            Console.WriteLine("Enter a fruit: ");
            string fruit = Console.ReadLine();

            Console.WriteLine("Enter a superhero: ");
            string superhero = Console.ReadLine();

            Console.WriteLine("Enter a country: ");
            string country = Console.ReadLine();

            Console.WriteLine("Enter an dessert: ");
            string dessert = Console.ReadLine();

            Console.WriteLine("Enter an year: ");
            string year = Console.ReadLine();




            // The template for the story:

            string story = $"Last night, {name} woke up feeling quite {firstAdj}. 'It's going to be a freakin {secondAdj} day!' Outside, a bunch of wild {animal}s were protesting to keep {food} in stores because the government was totally all up in their business. They began to {verb} and decided to kidna sorta kidnap a {firstNoun}, which made all the {fruit}s very {thirdAdj}. Concerned, {name} texted {superhero} while we has on the toilet, who flew {name} to the lovely {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {secondNoun}s ruled the world and no one wore pants";


            // Print the story:
            Console.WriteLine(story);
        }
    }
}
