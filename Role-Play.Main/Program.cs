using System;
using System.Collections.Generic;


//Displays and creates

namespace Role_Play.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runProgram = true;
            while (runProgram == true)
            {
                Console.WriteLine("\nWelcome to the Role-Playing Assistant! With this program you can create a character, save them to the program, and load them for later use! You can also use this program to roll dice!");
                Console.WriteLine("Enter the following based on what you want to do:");
                Console.WriteLine("Enter '1' to create a character.");
                Console.WriteLine("Enter '2' to view and load the stats of your saved characters.");
                Console.WriteLine("Enter '3' to simulate rolling dice.");
                Console.WriteLine("Enter '4' to exit the program.");
                var input = Logic.ValidateInt("\nWhat will you do?", 1, 4);

                if (input == 1)
                {
                    Console.WriteLine("\nType your response to each question below, make sure you input your answer correctly before submitting.");
                    new Logic.Character();
                    Console.WriteLine("Done! Feel free to select the loading option from the main menu to view the stats of your character.");
                }

                else if (input == 2)
                {
                    bool stayHere = true;
                    while (stayHere == true)
                    {
                        Console.WriteLine("\nBelow is a list of the characters that are saved to the system.");
                        Logic.Character.Load();
                        int confirm = Logic.ValidateInt("\nWould you like to see any other characters? (Enter 1 to view other characters, 2 to exit to the main menu)", 1, 2);
                        if (confirm == 1)
                        {
                            stayHere = true;
                        }
                        else
                        {
                            stayHere = false;
                        }
                    }
                }

                else if (input == 3)
                {
                    bool keepRolling = true;
                    while (keepRolling == true)
                    {
                        Console.WriteLine("\nHere you will be asked how many dice of various side-values you would like to roll. When prompted, just input the amount of each respective die-type and the program will tell you what your total is!");
                        new Logic.Dice.RollAll();
                        var confirmRoll = Logic.ValidateInt("\nWould you like to keep rolling? Input 1 to continue, 2 to exit.", 1, 2);
                        if (confirmRoll == 1)
                        {
                            keepRolling = true;
                        }
                        else
                        {
                            keepRolling = false;
                        }
                    }
                }

                else if (input == 4)
                {
                    runProgram = false;
                }
            }
        }
    }
}

/*Expected workflow for testing:
Go to the character creation options to create and save a new character
Make sure the character file was properly written to and can be loaded again
Go to the terminal that will allow me to roll dice and make sure it works properly

In more detail: 
    Enter 1 to get to character creation screen, fill in all required
so that the program can save that character to a text file. Exit.
    Enter 2 from the main screen to enter the screen that will display the names
of all saved characters. Upon typing in the name of your character, it will pull
up the stats of that character. Exit.
    Enter 3 to enter the dice rolling screen where the user can choose how
many and what kinds of dice they are rolling. If it works correctly, exit.
*/
