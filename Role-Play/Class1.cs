using System;

//Logic

//Next step: Dice
//

namespace Role_Play
{
    //For rolling Dice
    public class Class1
    {
        static int ValidateInt(string prompt, int min = 0, int max = int.MaxValue)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                try
                {
                    var intInput = int.Parse(Console.ReadLine());
                    if (intInput <= max && intInput >= min)
                    {
                        return intInput;
                    }
                    else if (intInput > max || intInput < min)
                    {
                        Console.WriteLine($"\nThat isn't within your options between {min} and {max}.");
                    }
                }
                catch
                {
                    Console.WriteLine("That didn't work, try using one of the suggested options.");
                }
            }
        }
        public class Dice
        {
            public interface IDice
            {
                int numSides();
                void numRolls();
            }

            public class D4 : IDice
            {
                public int numSides()
                {
                    return 4;
                }
                public void numRolls()
                {
                    //Will roll these dice as many times as dictated by the user from the main project
                    //Code pending
                }
            }

            public class D6 : IDice
            {
                public int numSides()
                {
                    return 6;
                }
                public void numRolls()
                {
                    //Will roll these dice as many times as dictated by the user from the main project
                    //Code pending
                }
            }

            public class D8 : IDice
            {
                public int numSides()
                {
                    return 8;
                }
                public void numRolls()
                {
                    //Will roll these dice as many times as dictated by the user from the main project
                    //Code pending
                }
            }

            public class D10 : IDice
            {
                public int numSides()
                {
                    return 10;
                }
                public void numRolls()
                {
                    //Will roll these dice as many times as dictated by the user from the main project
                    //Code pending
                }
            }

            public class D12 : IDice
            {
                public int numSides()
                {
                    return 12;
                }
                public void numRolls()
                {
                    //Will roll these dice as many times as dictated by the user from the main project
                    //Code pending
                }
            }

            public class D20 : IDice
            {
                public int numSides()
                {
                    return 20;
                }
                public void numRolls()
                {
                    //Will roll these dice as many times as dictated by the user from the main project
                    //Code pending
                }
            }
        }
    }
}
