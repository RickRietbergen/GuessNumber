using System;
using System.Collections.Generic;
using System.Text;

namespace guessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            string response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                //number = 1-100
                number = random.Next(min, max + 1);

                while (guess != number)
                {
                    //guess number between 1-100
                    Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is to high!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is to low!");
                    }
                    guesses++;
                }
                Console.WriteLine("Number: " + number);
                Console.WriteLine("You guessed the number!");
                Console.WriteLine("Guesses: " + guesses);

                Console.WriteLine("Would you like to play again? (Y/N): ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playAgain = true;
                }
                if (response == "N")
                {
                    playAgain = false;
                    Console.WriteLine("Thanks for playing");
                }
            }
            Console.ReadKey();
        }
    }
}