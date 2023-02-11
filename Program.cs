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
            //        Description: This game involves a secret number being chosen by the computer within a specific range(let’s say 1 - 100) and the player then tries to guess this number.

            //If the number they guess is too low, the program will say “too low” and if it is too high it will reply with “too high”. The player wins when they guess the correct number.
            //Tips: First thing to look at is generating a random number. Despite the language you choose, most of the time a random number can be created using a random generator function or object.
            //.NET has the “Random” object and C++ has rand().
            //Once you have a random number chosen, ask the player for a guess.
            //Compare their guess to this random number chosen.An easy if statement can be used to see if it is too high or too low.If they are equal, tell the player they win and restart the game.
            //Added Difficulty: Put a limit on how many wrong guesses they can have.Too many and the game ends with “You lose”.


            //Create a Random object that creates a random number 1- 100
            //Take user input and store it in a variable called userGuess
            //Declare a variable that store the number of guesses that users has
            //Create an if statement where if the user introduces a valid number you can make that object random to generate the number and check if
            //the player guess is the same as the number generated and prin a message accordingly

            //


            Console.WriteLine("Please enter a number from 1 to 100: ");
            int userGuess = Convert.ToInt32(Console.ReadLine());

            Random rand = new Random();
          
            int numberOfTries = 0;
            int maxNumberOfTries = 12;

            bool finish = true;
            int randomNumber = rand.Next(1, 100);

            while(finish)
            {

                if(userGuess < randomNumber && numberOfTries < maxNumberOfTries)
                {
                    Console.WriteLine("Your guess is too low. Please try again: ");
                    numberOfTries++;
                    userGuess = Convert.ToInt32(Console.ReadLine());

                }
                else if (userGuess > randomNumber && numberOfTries < maxNumberOfTries)
                {
                    Console.WriteLine("Your guess is too high. Please try again: ");
                    numberOfTries++;
                    userGuess = Convert.ToInt32(Console.ReadLine());
                }
                else if (maxNumberOfTries == numberOfTries)
                {
                    Console.WriteLine("You lost! Maximum number of tries reached");
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