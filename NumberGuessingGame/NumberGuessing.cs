using System;
using System.Collections.Generic;
using System.Text;

namespace NumberGuessingGame
{
    internal class NumberGuessing
    {
       private int numberToGuess = 0;
        int userGuess = 0;
        int minimum = 0;
        int maximum = 0;
        
        public NumberGuessing(int minimum,int maximum)
        {
            Random rand = new Random();
            numberToGuess = rand.Next(minimum, maximum);

            this .minimum = minimum;
            this .maximum = maximum;
        }

        public GuessResult MakeGuess(int guess)
        {
            if (guess > maximum || guess < minimum)
            {
                return GuessResult.OutOfLimits;
            }
            else if (guess == numberToGuess)
            {
                GuessResult result = GuessResult.Correct;

                return result;
            }
            else if (guess < numberToGuess)
            {
                return GuessResult.TooLow;
            }
            else
            {
                return GuessResult.TooHigh;
            }
        }    
    }
}
