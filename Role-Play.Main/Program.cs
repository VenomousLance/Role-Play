using System;
using System.Collections.Generic;



//Displays and creates

namespace Role_Play.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Role-Playing Assistant! With this program you can create a character, save them to the program, and load them for later use! You can also use this program to roll dice!");
            Console.WriteLine("Enter the following based on what you want to do:");
            Console.WriteLine("Enter '1' to create a character.");
            Console.WriteLine("Enter '2' to view and load the stats of your saved characters.");
            Console.WriteLine("Enter '3' to simulate rolling dice.");
            Console.ReadLine();

            List<int> Sides = new List<int>();
            Sides.Add(1);
            Sides.Add(2);
            Sides.Add(3);
            Sides.Add(4);

            /*
            int number = 15;

            while (number > 0)
            {
            var random = new Random();
            int roll = random.Next(Sides.Count);
            int rollValue = Sides[roll];
            Console.WriteLine(rollValue);
            number--;
            }
            */

            new Class1.Dice.D4Set();
            
            
            Console.WriteLine("Hi");
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
