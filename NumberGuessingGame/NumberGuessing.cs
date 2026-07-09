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

        public GuessingEnums MakeGuess(int guess)
        {
            if (guess > maximum || guess < minimum)
            {
                return GuessingEnums.OutOfLimits;
            }
            else if (guess == numberToGuess)
            {
                GuessingEnums result = GuessingEnums.Correct;

                return result;
            }
            else if (guess < numberToGuess)
            {
                return GuessingEnums.TooLow;
            }
            else
            {
                return GuessingEnums.TooHigh;
            }
        }    
    }
}
