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
            bool endGame = false;
           
            Console.WriteLine("WELCOME TO HEADS OR TAILS!\n");
            
            while (endGame == false)
            {
                Console.WriteLine("Please type 'heads' or 'tails': \n");

                string headsOrTailsGuess = Console.ReadLine();

                //put the users input to lowercase and verify if input valid
                if (headsOrTailsGuess.ToLower() != "tails" && headsOrTailsGuess.ToLower() != "heads")
                {
                    Console.WriteLine("\nNot a valid input\n");
                    continue;
                }


                Console.WriteLine("\nPlease input how many times you'd like to flip the coin: \n");

                string userFlips = Console.ReadLine();

                int numberOfFlips;

                //convert user input to number and verify if input is valid
                if (!int.TryParse(userFlips, out numberOfFlips))
                {
                    Console.WriteLine("\nThis is not a number.\n");
                    continue; //this is causing my program to go completely to the top and request for heads and tails :(
                }

                //if random number divisible by 2 (remainder of 0) then output tails, else, output heads
                //generate random number each time

                Console.WriteLine(); //adding new line before the flips are shown

                //begin loop to output coin flips

                for (int i = 0; i <= (numberOfFlips - 1); i += 1)
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


                //convert value to double
                double percentRight = (double)correctCount / numberOfFlips;

                //test final numbers
                //Console.WriteLine(correctCount);
                //Console.WriteLine(numberOfFlips);
                //Console.WriteLine(percentRight);

                percentRight = Math.Round(percentRight * 100);

                Console.WriteLine("\nYour guess, " + headsOrTailsGuess + ", came up " + correctCount + " times!");
                Console.WriteLine("You correctly guessed " + percentRight + "% of the coin flips!");
                endGame = true;
            }
        

            
           




        }
    }
}
