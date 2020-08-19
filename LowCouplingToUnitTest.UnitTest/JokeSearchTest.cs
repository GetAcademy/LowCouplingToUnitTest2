using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace LowCouplingToUnitTest.UnitTest
{
    class JokeSearchTest
    {
        [Test]
        public void Test1()
        {
            var jokeSearch = new JokeSearch();
            var jokes = new[]
            {
                "aaa bbb",
                "ccc bbb",
                "aaa aaa",
                "aaa aaa zzz",
            };
            var joke = jokeSearch.GetJokeWithWordTwoTimes("aaa", jokes);
            Assert.AreEqual("aaa aaa", joke);
        }
    }
}
