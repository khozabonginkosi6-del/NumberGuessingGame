namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool gameOver = false;
            bool inputValid = false;

            while (!gameOver)
            {
                int maximum = 0;
                string difficulty = string.Empty;

                while (!inputValid)
                {
                    Console.WriteLine("What Difficulty would you like? (E), (M), (H)");
                    difficulty = Console.ReadLine();

                    if ((difficulty == "E") || (difficulty == "M") || (difficulty == "H"))
                    {
                        inputValid = true;
                    }
                    else
                    {
                        Console.WriteLine("Please type (E), (M) OR (H)");
                        inputValid = false;
                    }
                }


                if (difficulty == "E")
                {
                    maximum = 10;
                }
                else if (difficulty == "M")
                {
                    maximum = 50;
                }
                else
                {
                    maximum = 1000;
                }

                NumberGuessing numberGuessing = new NumberGuessing(1, maximum);


                bool guessed = false;

                while (!guessed)
                {
                    Console.WriteLine("Please enter your guess:");

                    string guess = Console.ReadLine();
                    GuessResult result = numberGuessing.MakeGuess(int.Parse(guess));



                    if (result == GuessResult.TooLow)
                    {
                        Console.WriteLine("Your Guess is too LOW!  Please try again.");
                    }
                    else if (result == GuessResult.TooHigh)
                    {
                        Console.WriteLine("Your Guess is too HIGH!  Please try again.");

                    }
                    else if (result == GuessResult.Correct)
                    {
                        Console.WriteLine("Well Done!!!  You are correct.");
                        guessed = true;

                    }
                    else if (result == GuessResult.OutOfLimits)
                    {
                        Console.WriteLine("Out of range, are you kidding me?  Please try again.");
                    }

                }

                inputValid = false;
                string playAgain = string.Empty;

                while (!inputValid)
                {
                    Console.WriteLine("Do you want to play again? (Y) or (N)");
                    playAgain = Console.ReadLine();
                    playAgain = playAgain.ToUpper();

                    if ((playAgain == Decision.No.ToString()) || (playAgain == Decision.Yes.ToString()))
                    {
                        inputValid = true;
                    }
                    else
                    {
                        Console.WriteLine("Please type (Y) or (N)");
                        inputValid = false;
                    }
                }

                if (playAgain == "N")
                {
                    gameOver = true;
                }
                else if (playAgain == "Y")
                {
                    gameOver = false;
                }
            }
        }
    }
}