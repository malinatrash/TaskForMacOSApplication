using System;
using MacOSApp;
using NUnit.Framework;

namespace LogicTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void SquareIsEqualNine()
        {
            var number = "3";
            var answer = Logic.Calculate(number);
            Assert.AreEqual("9", answer);
        }

        [Test]
        public void SquareIsEqualNull()
        {
            var number = "0";
            var answer = Logic.Calculate(number);
            Assert.AreEqual("0", answer);
        }

        [Test]
        public void SquareIsEqualOne()
        {
            var number = "1";
            var answer = Logic.Calculate(number);
            Assert.AreEqual("1", answer);
        }
    }
}