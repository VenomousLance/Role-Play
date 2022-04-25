using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

//Logic


namespace Role_Play
{
    public class Logic
    {
        public static string AnyInput(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                try
                {
                    var input = Console.ReadLine();
                    if (input.Length > 0)
                    {
                        return input;
                    }
                    else if (input.Length == 0)
                    {
                        Console.WriteLine("You need to input something.");
                    }
                }
                catch
                {
                    Console.WriteLine("Something went wrong, try again.");
                }
            }
        }

        public static int ValidateInt(string prompt, int min, int max)
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
        public interface IFileAccess
        {
            static void Load() 
            {}
        }

        public class Character : IFileAccess
        {
            public Character()
            {
                ArrayList characterStats = new ArrayList();
                //Player Name
                string playerName = AnyInput("What is your name? (This is not your character's name)");
                characterStats.Add($"Your name: {playerName}");
                //Character Name
                string characterName = AnyInput("What is your character's name?");
                characterStats.Add($"Your character's name: {characterName}");
                //Race
                string race = AnyInput("What race is your character?");
                characterStats.Add($"Race: {playerName}");
                //Background
                string background = AnyInput("What is your character's background?");
                characterStats.Add($"Background: {background}");
                //Alignment
                string alignment = AnyInput("What is your character's alignment?");
                characterStats.Add($"Alignment: {alignment}");
                //Strength
                int strength = ValidateInt("What is your strength modifier?", int.MinValue, int.MaxValue);
                characterStats.Add($"Strength modifier: {strength}");
                //Dexterity
                int dexterity = ValidateInt("What is your dexterity modifier?", int.MinValue, int.MaxValue);
                characterStats.Add($"Dexterity modifier: {dexterity}");
                //Constitution
                int constitution = ValidateInt("What is your constitution modifier?", int.MinValue, int.MaxValue);
                characterStats.Add($"Constitution modifier: {constitution}");
                //Intelligence
                int intelligence = ValidateInt("What is your intelligence modifier?", int.MinValue, int.MaxValue);
                characterStats.Add($"Intelligence modifier: {intelligence}");
                //Wisdom
                int wisdom = ValidateInt("What is your wisdom modifier?", int.MinValue, int.MaxValue);
                characterStats.Add($"Wisdom modifier: {wisdom}");
                //Charisma
                int charisma = ValidateInt("What is your charisma modifier?", int.MinValue, int.MaxValue);
                characterStats.Add($"Charisma modifier: {charisma}");
                //Proficiency Bonus
                int proficiency = ValidateInt("What is your proficiency bonus?", int.MinValue, int.MaxValue);
                characterStats.Add($"Proficiency bonus: {proficiency}");
                //STStrength
                int savingThrowStr = ValidateInt("What is the value for your saving throw in strength?", int.MinValue, int.MaxValue);
                characterStats.Add($"Saving throw (strength): {savingThrowStr}");
                //STDex
                int savingThrowDex = ValidateInt("What is the value for your saving throw in dexterity?", int.MinValue, int.MaxValue);
                characterStats.Add($"Saving throw (dexterity): {savingThrowDex}");
                //STConst
                int savingThrowConst = ValidateInt("What is the value for your saving throw in constitution?", int.MinValue, int.MaxValue);
                characterStats.Add($"Saving throw (constitution): {savingThrowConst}");
                //STInt
                int savingThrowIntel = ValidateInt("What is the value for your saving throw in intelligence?", int.MinValue, int.MaxValue);
                characterStats.Add($"Saving throw (intelligence): {savingThrowIntel}");
                //STWis
                int savingThrowWis = ValidateInt("What is the value for your saving throw in wisdom?", int.MinValue, int.MaxValue);
                characterStats.Add($"Saving throw (wisdom): {savingThrowWis}");
                //STChar
                int savingThrowCharm = ValidateInt("What is the value for your saving throw in charisma?", int.MinValue, int.MaxValue);
                characterStats.Add($"Saving throw (charisma): {savingThrowCharm}");
                //Armor Class
                int armorClass = ValidateInt("What is your armor class value?", int.MinValue, int.MaxValue);
                characterStats.Add($"Armor class: {armorClass}");
                //Initiative
                int initiative = ValidateInt("What is your initiative?", int.MinValue, int.MaxValue);
                characterStats.Add($"Initiative: {initiative}");
                //Speed
                int speed = ValidateInt("What is your speed value?", int.MinValue, int.MaxValue);
                characterStats.Add($"Speed: {speed}");
                //Max Hit Points
                int maxHP = ValidateInt("What is the maximum value of your hit points?", int.MinValue, int.MaxValue);
                characterStats.Add($"Max HP: {maxHP}");
                string characterFile = $"{characterName}.txt";
                string allCharacterFiles = "allCharacters.txt";

                    if (!File.Exists(characterFile))
                    {
                        TextWriter saveTo = new StreamWriter(characterFile);
                        StreamWriter allChar = File.AppendText(allCharacterFiles);
                        allChar.WriteLine(characterName);
                        allChar.Close();
                        int index = 0;

                        foreach (var i in characterStats)
                        {
                            saveTo.WriteLine(characterStats[index]);
                            index++;
                        }
                        saveTo.Close();
                    }

                //Advanced Stuff!!! (Will require a loop to potentially add multiple)
                //Attacks
                //Equipment
                //Personality Traits
                //Ideals
                //Bonds
                //Flaws
                //Traits
            }

            public static void Load()
            {
                int index = 0;
                var reader = new ArrayList();

                try
                {
                    TextReader readFrom = new StreamReader("allCharacters.txt");
                    string line = "";
                    int counter = 0;

                    while ((line = readFrom.ReadLine()) != null)
                    {
                        reader.Add(line);
                        counter++;
                    }

                    foreach (var i in reader)
                    {
                        Console.WriteLine($"{index}. {i}");
                        index++;
                    }
                    readFrom.Close();
                }
                catch
                {
                    Console.WriteLine("Something went wrong.");
                }

                int characterSelect = ValidateInt("\nEnter the number of the character whose stats you would like to see.", 0, index);
                try
                {
                    TextReader readStats = new StreamReader($"{reader[characterSelect]}.txt");
                    string line = "";
                    int counter = 0;
                    var readerStats = new ArrayList();

                    while ((line = readStats.ReadLine()) != null)
                    {
                        readerStats.Add(line);
                        counter++;
                    }

                    foreach (var j in readerStats)
                    {
                        Console.WriteLine(j);
                    }
                    readStats.Close();
                }
                catch
                {
                    Console.WriteLine("ERROR: File doesn't exist!");
                }
            }
        }

        public class Dice
        {
            public interface IDice
            {
                public List<int> Sides { get; set; }
                public int diceValues();
                public int numDice { get; set; }
            }

            public class RollAll
            {
                public RollAll()
                {
                    int sumTotal = 0;
                    D4Set allD4 = new D4Set();
                    D6Set allD6 = new D6Set();
                    D8Set allD8 = new D8Set();
                    D12Set allD12 = new D12Set();
                    D20Set allD20 = new D20Set();
                    sumTotal = allD4.Total + allD6.Total + allD8.Total + allD12.Total + allD20.Total;
                    Console.WriteLine($"The total of all the dice is {sumTotal}");

                }
            }

            public class D4Set : IDice
            {
                public List<int> Sides { get; set; }
                public int numDice { get; set; }
                public int Total { get; set; }

                public D4Set()
                {
                    Sides = new List<int>();
                    Sides.Add(1);
                    Sides.Add(2);
                    Sides.Add(3);
                    Sides.Add(4);
                    numDice = ValidateInt("\nHow many d4 would you like to roll?", 0, 1000);
                    Total = diceValues();
                }

                public int diceValues()
                {
                    var random = new Random();
                    while (numDice > 0)
                    {
                        int roll = random.Next(Sides.Count);
                        int rollValue = Sides[roll];
                        Console.WriteLine($"You rolled a {rollValue}");
                        Total += rollValue;
                        numDice--;
                    }
                    Console.WriteLine($"This total is {Total}");
                    return Total;
                }
            }

            public class D6Set : IDice
            {
                public List<int> Sides { get; set; }
                public int numDice { get; set; }
                public int Total { get; set; }

                public D6Set()
                {
                    Sides = new List<int>();
                    Sides.Add(1);
                    Sides.Add(2);
                    Sides.Add(3);
                    Sides.Add(4);
                    Sides.Add(5);
                    Sides.Add(6);
                    numDice = ValidateInt("\nHow many d6 would you like to roll?", 0, 1000);
                    Total = diceValues();
                }

                public int diceValues()
                {
                    var random = new Random();
                    while (numDice > 0)
                    {
                        int roll = random.Next(Sides.Count);
                        int rollValue = Sides[roll];
                        Console.WriteLine($"You rolled a {rollValue}");
                        Total += rollValue;
                        numDice--;
                    }
                    Console.WriteLine($"This total is {Total}");
                    return Total;
                }
            }

            public class D8Set : IDice
            {
                public List<int> Sides { get; set; }
                public int numDice { get; set; }
                public int Total { get; set; }

                public D8Set()
                {
                    Sides = new List<int>();
                    Sides.Add(1);
                    Sides.Add(2);
                    Sides.Add(3);
                    Sides.Add(4);
                    Sides.Add(5);
                    Sides.Add(6);
                    Sides.Add(7);
                    Sides.Add(8);
                    numDice = ValidateInt("\nHow many d8 would you like to roll?", 0, 1000);
                    Total = diceValues();
                }

                public int diceValues()
                {
                    var random = new Random();
                    while (numDice > 0)
                    {
                        int roll = random.Next(Sides.Count);
                        int rollValue = Sides[roll];
                        Console.WriteLine($"You rolled a {rollValue}");
                        Total += rollValue;
                        numDice--;
                    }
                    Console.WriteLine($"This total is {Total}");
                    return Total;
                }
            }

            public class D12Set : IDice
            {
                public List<int> Sides { get; set; }
                public int numDice { get; set; }
                public int Total { get; set; }

                public D12Set()
                {
                    Sides = new List<int>();
                    Sides.Add(1);
                    Sides.Add(2);
                    Sides.Add(3);
                    Sides.Add(4);
                    Sides.Add(5);
                    Sides.Add(6);
                    Sides.Add(7);
                    Sides.Add(8);
                    Sides.Add(9);
                    Sides.Add(10);
                    Sides.Add(11);
                    Sides.Add(12);
                    numDice = ValidateInt("\nHow many d12 would you like to roll?", 0, 1000);
                    Total = diceValues();
                }

                public int diceValues()
                {
                    var random = new Random();
                    while (numDice > 0)
                    {
                        int roll = random.Next(Sides.Count);
                        int rollValue = Sides[roll];
                        Console.WriteLine($"You rolled a {rollValue}");
                        Total += rollValue;
                        numDice--;
                    }
                    Console.WriteLine($"This total is {Total}");
                    return Total;
                }
            }

            public class D20Set : IDice
            {
                public List<int> Sides { get; set; }
                public int numDice { get; set; }
                public int Total { get; set; }

                public D20Set()
                {
                    Sides = new List<int>();
                    Sides.Add(1);
                    Sides.Add(2);
                    Sides.Add(3);
                    Sides.Add(4);
                    Sides.Add(5);
                    Sides.Add(6);
                    Sides.Add(7);
                    Sides.Add(8);
                    Sides.Add(9);
                    Sides.Add(10);
                    Sides.Add(11);
                    Sides.Add(12);
                    Sides.Add(13);
                    Sides.Add(14);
                    Sides.Add(15);
                    Sides.Add(16);
                    Sides.Add(17);
                    Sides.Add(18);
                    Sides.Add(19);
                    Sides.Add(20);
                    numDice = ValidateInt("\nHow many d20 would you like to roll?", 0, 1000);
                    Total = diceValues();
                }

                public int diceValues()
                {
                    var random = new Random();
                    while (numDice > 0)
                    {
                        int roll = random.Next(Sides.Count);
                        int rollValue = Sides[roll];
                        Console.WriteLine($"You rolled a {rollValue}");
                        Total += rollValue;
                        numDice--;
                    }
                    Console.WriteLine($"This total is {Total}");
                    return Total;
                }
            }
        }
    }
}
