namespace HighLowNumberGuessingGame
{
    internal class Program
    {
        const int MAX_NUMBER_OF_TRIES = 12;
        const int MIN_RAND_VALUE = 1;
        const int MAX_RAND_VALUE = 101;

        static void Main(string[] args)
        {       
            Random rand = new Random();
          
            int numberOfTries = 0;
            int closeGuess = 0;
            bool finish = true;
            int randomNumber = rand.Next(MIN_RAND_VALUE,MAX_RAND_VALUE); // Choose a random number 1 to 100

            // loops until max number of tries is reached or the pleayer guesses the number
            while(finish)  
            {
                Console.WriteLine("Please enter a number from 1 to 100: ");
                int userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess < randomNumber)
                {
                    Console.WriteLine("Your guess is too low. Please try again: ");
                    numberOfTries++;               
                }
                else if (userGuess > randomNumber)
                {
                    Console.WriteLine("Your guess is too high. Please try again: ");
                    numberOfTries++;               
                }           
                else if (MAX_NUMBER_OF_TRIES == numberOfTries)
                {
                    Console.WriteLine("You lost! Maximum number of tries reached!");
                    finish = false;
                }
                else if (userGuess == randomNumber)
                {
                    Console.WriteLine("You guessed the number! It took you " + numberOfTries + " tries!");
                    finish = false;
                    break;
                }

                // returns the absolute positive value of the difference between RandomNumber and userGuess
                closeGuess = Math.Abs(randomNumber - userGuess);
                if (closeGuess <= 5)
                {
                    Console.WriteLine("You are close!");
                }
            }           
            Console.ReadLine();
        }
    }
}