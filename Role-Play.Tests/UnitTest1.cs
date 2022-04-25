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

            Logic.Dice.D4Set D4Test = new Logic.Dice.D4Set();

            Assert.AreEqual(4, D4Test.Sides.Count);
        }
    }
}