using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string guessWord = "shivam";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 4;
            bool isOutOfGuesses = false;
            
            while(guess != guessWord && !isOutOfGuesses)
            {
                if(guessCount < guessLimit)
                {
                    Console.Write("Enter word: ");
                    guess = Console.ReadLine();
                    guessCount++;
                    if(guess != guessWord)
                    {
                        int guessesLeft = guessLimit - guessCount;
                        Console.WriteLine("Guesses Left " + guessesLeft);
                    }
                   
                }
                else
                {
                    isOutOfGuesses = true;
                }            
            }
            if( isOutOfGuesses)
            {
                Console.WriteLine("\nYou Lose!");
            }
            else
            {
                Console.WriteLine("\nYou Win! in " + guessCount + " " +"guesses");
            }
            
        }
        

    }
}

