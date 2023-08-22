﻿using NUnit.Framework;

namespace IfStatements.Tests
{
    [TestFixture]
    public class Task7Tests
    {
        [TestCase(true, 0, ExpectedResult = 7)]
        [TestCase(true, 1, ExpectedResult = 6)]
        [TestCase(true, 2, ExpectedResult = 5)]
        [TestCase(true, 3, ExpectedResult = 4)]
        [TestCase(true, 4, ExpectedResult = 3)]
        [TestCase(true, 5, ExpectedResult = 2)]
        [TestCase(true, 6, ExpectedResult = 1)]
        [TestCase(true, 7, ExpectedResult = 7)]
        [TestCase(true, 8, ExpectedResult = 8)]
        [TestCase(true, 9, ExpectedResult = 9)]
        [TestCase(true, 10, ExpectedResult = 10)]
        [TestCase(true, -1, ExpectedResult = 8)]
        [TestCase(true, -2, ExpectedResult = 9)]
        [TestCase(true, -3, ExpectedResult = 10)]
        [TestCase(true, -4, ExpectedResult = 11)]
        [TestCase(true, -5, ExpectedResult = 12)]
        [TestCase(true, -6, ExpectedResult = 13)]
        [TestCase(true, -7, ExpectedResult = -7)]
        [TestCase(true, -8, ExpectedResult = -8)]
        [TestCase(true, -9, ExpectedResult = -9)]
        [TestCase(true, -10, ExpectedResult = -10)]
        [TestCase(false, 0, ExpectedResult = 0)]
        [TestCase(false, 1, ExpectedResult = 1)]
        [TestCase(false, 2, ExpectedResult = 2)]
        [TestCase(false, 3, ExpectedResult = 3)]
        [TestCase(false, 4, ExpectedResult = 4)]
        [TestCase(false, 5, ExpectedResult = 10)]
        [TestCase(false, 6, ExpectedResult = 11)]
        [TestCase(false, 7, ExpectedResult = 12)]
        [TestCase(false, 8, ExpectedResult = 13)]
        [TestCase(false, 9, ExpectedResult = 14)]
        [TestCase(false, 10, ExpectedResult = 15)]
        [TestCase(false, -1, ExpectedResult = -1)]
        [TestCase(false, -2, ExpectedResult = -2)]
        [TestCase(false, -3, ExpectedResult = -3)]
        [TestCase(false, -4, ExpectedResult = -4)]
        [TestCase(false, -5, ExpectedResult = 0)]
        [TestCase(false, -6, ExpectedResult = -1)]
        [TestCase(false, -7, ExpectedResult = -2)]
        [TestCase(false, -8, ExpectedResult = -3)]
        [TestCase(false, -9, ExpectedResult = -4)]
        [TestCase(false, -10, ExpectedResult = -5)]
        public int DoSomething_ReturnsBool(bool b, int i)
        {
            return Task7.DoSomething(b, i);
        }
    }
}
