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

            //create a new instance of our number guesser class
            var numberGuesser = new NumberGuesser();

            //change default to 200
            numberGuesser.MaximumNumber = 200;

            //ask user to think of a number
            numberGuesser.InformUser();         

            //discover the number the user is thinking of
            numberGuesser.DiscoverNumber();

            //announce the results
            numberGuesser.AnnounceResults();
        }
    }
}
