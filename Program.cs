using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;

namespace HighLowNumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a number from 1 to 100: ");
            int userGuess = Convert.ToInt32(Console.ReadLine());
         
            Random rand = new Random();
          
            int numberOfTries = 0;
            const int MAX_NUMBER_OF_TRIES = 12;

            bool finish = true;
            int randomNumber = rand.Next(0, 101); // Choose a random number 1 to 100

            // loops until max number of tries is reached or the pleayer guesses the number
            while(finish)  
            {
                if(userGuess < randomNumber)
                {
                    Console.WriteLine("Your guess is too low. Please try again: ");
                    numberOfTries++;
                    userGuess = Convert.ToInt32(Console.ReadLine());
                }
                else if (userGuess > randomNumber)
                {
                    Console.WriteLine("Your guess is too high. Please try again: ");
                    numberOfTries++;
                    userGuess = Convert.ToInt32(Console.ReadLine());
                }
                else if (MAX_NUMBER_OF_TRIES == numberOfTries)
                {
                    Console.WriteLine("You lost! Maximum number of tries reached!");
                    finish = false;
                }
                else if (userGuess == randomNumber)
                {
                    Console.WriteLine("You guessed the number! It took you " + numberOfTries);
                    finish = false;
                }
            }           
            Console.ReadLine();
        }
    }
}