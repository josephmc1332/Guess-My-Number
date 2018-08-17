using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngelSixTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask user to think of number in specified range.
            Console.WriteLine("I want you to think of a number between 1 and 100");
            Console.ReadLine();

            //define max number
            int max = 100;

            //keep track of guesses
            int guesses = 0;

            //start guess from
            int guessMin = 0;

            //the start guess to (half of max)
            int guessMax = max / 2;

            //while the guess isn't the same as max number
            while (guessMin != max)
            {
                //increase guess amount (by 1)
                guesses++;

                //ask the user if their number is between the guess range.
                Console.WriteLine($"is you number between {guessMin} and {guessMax}?");
                string response = Console.ReadLine();

                //if user confirmed thier number is within the range
                if (response?.ToLower().FirstOrDefault() == 'y' || response?.FirstOrDefault() == 'Y')
                {
                    //We know the number is between guessMin and guessMax
                    //So set the new maximum number
                    max = guessMax;
                    

                    //change the next guess range to half of the new max range
                    guessMax = guessMax - (guessMax - guessMin) / 2;
                }
                //The number is greater than guessMax and less than or equal to max
                else
                {
                    //the new minimum is above the old maximu
                    guessMin = guessMax + 1;

                    //guess the bottom half of the new range
                    int remainingDifference = max - guessMax;

                    //set the guess max to half way between guessMin and guessMax
                    //NOTE:Math.Ceiling will round up the remaining difference to 2, if the difference is 3
                    guessMax += (int)Math.Ceiling(remainingDifference / 2f);


                }
                //if we only have 2 numbers left, guess one of them
                if (guessMin + 1 == max)
                {
                    //increase guess amount by 1
                    guesses++;

                    //ask the user if their number is the lower number
                    Console.WriteLine($"is your number {guessMin}?");
                    response = Console.ReadLine();


                    //if the user confirmed their number is the lower number
                    if (response?.ToLower().FirstOrDefault() == 'y')
                    {
                        break;
                    }
                    else
                    {
                        guessMin = max;
                        break;

                        
                    }
                }
            }
            //tell the user their number
            Console.WriteLine($"**Your number is {guessMin}");
            //let the user know how many guesses it took
            Console.WriteLine($"Guessed in {guesses} guesses");
        }
    }
}
