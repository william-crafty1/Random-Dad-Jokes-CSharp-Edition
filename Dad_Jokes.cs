using System;

namespace Random_Joke
{
    class Dad_Jokes
    {
        static void Main(string[] args)
        {
            Console.Title = "Random Dad Jokes C# Edition";

            // array of jokes
            string[] jokeArray = {
                "What time did the man go to the dentist? Tooth hurt-y.",
                "Which U.S. state is famous for its extra-small soft drinks? Minnesota!",
                "I’m so good at sleeping I can do it with my eyes closed!",
                "If two vegans get in a fight, is it still considered a beef?",
                "What do you call a fake noodle? An Impasta.",
                "Why don’t skeletons ever go trick or treating? Because they have nobody to go with.",
                "I got so angry the other day when I couldn’t find my stress ball.",
                "I went to buy some camouflage trousers the other day, but I couldn’t find any.",
                "What do you call a belt with a watch on it? A waist of time.",
                "Don't trust atoms. They make up everything!",
                "Did you hear about the man who stole a calendar? He got 12 months.",
                "I am terrified of elevators. I’m going to start taking steps to avoid them.",
                "Why was the big cat disqualified from the race? Because it was a cheetah.",
                "“Doctor, I’ve broken my arm in several places” Doctor: “Well don’t go to those places.”",
                "What is Mario's favorite play? Mamma Mia!"
            };

            Random rndJoke = new Random();
            string choice = "";

            // user is prompt for a joke
            Console.WriteLine("How about a dad joke? Type Yes or Y to continue.\n Otherwise press any key to exit.");
            choice = Console.ReadLine();

            while(choice == "yes" || choice == "Yes" || choice == "YES" || choice == "Y" || choice == "y"){

                Console.ForegroundColor = ConsoleColor.Green;
                int jokeIndex = rndJoke.Next(jokeArray.Length);
                Console.WriteLine(jokeArray[jokeIndex]);
                Console.ReadKey();
                Console.ResetColor();

                Console.WriteLine("Want to continue?(Yes or Y to continue, any key for no)");
                choice = Console.ReadLine();
            }

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("PROGRAM TERMINATED");
            Console.ResetColor();
        }
    }
}
