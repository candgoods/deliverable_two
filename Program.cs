using System;
using System.Reflection.Metadata.Ecma335;

namespace deliverable2
{
    class Program
    {
        static void Main(string[] args)

        {

            int correctCount = 0;
            Random rand = new Random();
        
            string coin;
            bool invalidInput = false;

            Console.WriteLine("WELCOME TO HEADS OR TAILS!\n");
            Console.WriteLine("Please type 'heads' or 'tails': \n");

            string headsOrTailsGuess = Console.ReadLine();

            //put the users input to lowercase

            if (headsOrTailsGuess.ToLower() != "tails" && headsOrTailsGuess.ToLower() != "heads")
            {
                Console.WriteLine("Not a valid input");
            }

            Console.WriteLine("\nPlease input how many times you'd like to flip the coin: \n");

            string userFlips = Console.ReadLine();

            int numberOfFlips;

            if (!int.TryParse(userFlips, out numberOfFlips))
            {
                Console.WriteLine("\n This is not a number");
            }

            //if random number divisible by 2 (remainder of 0) then output tails, else, output heads
            //generate random number each time

            Console.WriteLine(); //adding new line before the flips are shown

            //begin loop to output coin flips

            for (int i = 0; i <= (numberOfFlips-1); i += 1)
            {
                int coinFlip = rand.Next();

                //testing to make sure random number generated
                //Console.WriteLine(coinFlip);

                if (coinFlip % 2 == 0)
                {
                    Console.WriteLine("tails");
                    coin = "tails";
                    if (coin == "tails" && headsOrTailsGuess == "tails")
                    {
                        correctCount++;
                    }
                }
                else
                {
                    Console.WriteLine("heads");
                    coin = "heads";
                    if (coin == "heads" && headsOrTailsGuess == "heads")
                    {
                        correctCount++;
                    }
                }
            }

            int percent = correctCount / numberOfFlips;
            percent = percent * 100;

            Console.WriteLine("\nYour guess was " + headsOrTailsGuess + "!");
            Console.WriteLine("Your guess was generated" + correctCount + " times!");
            Console.WriteLine("You correctly guessed " + percent + "% of the flips!");
        

            
           




        }
    }
}
