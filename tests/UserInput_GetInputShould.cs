using NUnit.Framework;
using BasicGroceryApp;
using System;
using System.IO;

namespace tests
{
    [TestFixture]
    public class UserInput_GetInputShould
    {
        private UserInput _userInput;
        [SetUp]
        public void Setup()
        {
            _userInput = new UserInput();
        }

        [Test]
        public void GetInput_InputIs0_ReturnMinus1()
        {
            Console.SetIn(new StringReader("0"));
            var result = _userInput.GetInput();
            Assert.AreEqual(result, -1);
        }

        [Test]
        public void GetInput_InputIsString_ReturnMinus1()
        {
            Console.SetIn(new StringReader("abc"));
            var result = _userInput.GetInput();
            Assert.AreEqual(result, -1);
        }
    }
}