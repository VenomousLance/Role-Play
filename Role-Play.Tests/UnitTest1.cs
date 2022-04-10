using NUnit.Framework;
using System.Collections.Generic;


namespace Role_Play.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void TestDice4()
        {

            Class1.Dice.D4Set D4Test = new Class1.Dice.D4Set(5);

            Assert.AreEqual(5, D4Test.numDice);
        }
    }
}