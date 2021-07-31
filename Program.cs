using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DG
{
    class Program
    {
        static int rollDice(int s, int result)
        {

            return result;

        }
        static void Main(string[] args)
        {
            //declare variables
            string response = "y";
            string sidesS;
            int sidesI;
            bool isItANum; //for my TryParse
            int again = 1; //counter

            Console.Write("Welcome! Roll the dice? (y/n): ");



            response = Console.ReadLine().ToLower();
            while (response == "y")
            {
                //user prompts
                Console.Write("How many sides should each die have? ");
                sidesS = Console.ReadLine();
                isItANum = int.TryParse(sidesS, out sidesI);
                while (!isItANum)
                {
                    //catches characters that are not numbers
                    Console.Write("Error the number you entered was invalid. Would you like to try again? (y/n)");
                    response = Console.ReadLine().ToLower();
                    Console.Write("How many sides should each die have? ");
                    sidesS = Console.ReadLine();
                    isItANum = int.TryParse(sidesS, out sidesI);

                }

                string input = "y";


                int playerRandomNum;
                int enemyRandomNum;

                int playerPoints = 0;
                int enemyPoints = 0;

                Random random = new Random();

                // Loop 20 times
                for (int i = 0; i < 20; i++)
                {
                    Console.WriteLine("Press any key to roll the dice."); // Displays message asking player to press any key

                    Console.ReadKey(); // Waits for the player to press any key before generating number

                    playerRandomNum = random.Next(1, 20); // Generates a random number between 1 and 6 for player
                    Console.WriteLine("You rolled a " + playerRandomNum); // Prints out player's randomly generated number

                    Console.WriteLine("...");
                    System.Threading.Thread.Sleep(1000); // Waits one second

                    enemyRandomNum = random.Next(1, 7); // Generates a random number between 1 and 6 for enemy
                    Console.WriteLine("Enemy AI rolled a " + enemyRandomNum); // Prints out enemy's randomly generated number

                    // If the player rolls higher than enemy
                    if (playerRandomNum > enemyRandomNum)
                    {
                        playerPoints++; // Increase player points
                        Console.WriteLine("Player wins this round!"); // Display message saying player has won this round
                    }
                    else if (playerRandomNum < enemyRandomNum) // If the enemy rolls higher than player
                    {
                        enemyPoints++; // Increase enemy points
                        Console.WriteLine("Enemy wins this round!"); // Display message saying enemy has won this round
                    }
                    else // If player and enemy have rolled the same number
                    {
                        Console.WriteLine("Draw!"); // Display message saying this round is a draw
                    }

                    // Displays player and enemy scores
                    Console.WriteLine("The score is now - Player : " + playerPoints + ". Enemy : " + enemyPoints + ".");
                    Console.WriteLine(); // Creates an empty line in between each round
                }

                // If the player has scored higher than enemy
                if (playerPoints > enemyPoints)
                {
                    Console.WriteLine("You win!"); // Display a message saying player wins
                }
                else if (playerPoints < enemyPoints) // If the enemy has scored higher than player
                {
                    Console.WriteLine("You lose!"); // Display message saying player loses
                }
                else // If player and enemy score the same amount of points
                {
                    Console.WriteLine("It's a draw!"); // Display message saying it's a draw
                    Console.WriteLine("Snake Eyes"); //Display message saying snake eyes
                }
                

                Console.ReadKey(); // Wait for user input before console window closes
            }
        }
    }
}

      





