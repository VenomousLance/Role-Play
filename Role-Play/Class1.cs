using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

//Logic

//Next step: Dice
//Make a method that will return an instance of a D4-Set

namespace Role_Play
{
    //For rolling Dice
    public class Class1
    {
        static int ValidateInt(string prompt, int min, int max)
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

        public class Character
        {
            public bool Save(string file)
            {
                try
                {
                    TextWriter saveTo = new StreamWriter(file);

                    saveTo.WriteLine("Character name here");
                    saveTo.WriteLine("Character class here");
                    saveTo.WriteLine("Character race here");
                    saveTo.Close();
                }
                catch
                {
                    return false;
                }
                return true;
            }

            public bool Load(string file)
            {
                try
                {
                    TextReader readFrom = new StreamReader(file);
                    string line = "";
                    var reader = new ArrayList();
                    int counter = 0;

                    while ((line = readFrom.ReadLine()) != null)
                    {
                        reader.Add(line);
                        counter++;
                    }

                    foreach (var i in reader)
                    {
                        Console.WriteLine(i);
                    }
                }
                catch
                {
                    return false;
                }
                return true;
            }
        }

        public class Dice
        {
            public interface IDice
            {
                public List<int> Sides { get; }
                public void diceValues();
            }

            public interface ISetCreator
            {
                public string SetType { get; }
                public IDice SetCreate();
            }

            public class D4Set : IDice
            {
                public List<int> Sides => new List<int>();
                public int numDice;

                public void diceValues()
                {
                    Sides.Add(1);
                    Sides.Add(2);
                    Sides.Add(3);
                    Sides.Add(4);

                    numDice = ValidateInt("How many d4 would you like to roll?", 0, 1000);
                    int total = 0;
                    var random = new Random();
                    int roll = random.Next(Sides.Count);
                    Console.WriteLine(Sides[roll]);

                    /*while (numDice >= 0)
                    {

                    }*/
                }

                public D4Set(List<int> sides, int numdice)
                {
                    sides = Sides;
                    numdice = numDice;
                }
            }

            //6,8,10,12,20
        }
    }
}
