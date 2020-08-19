using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace LowCouplingToUnitTest
{
    public class JokeSearch
    {
        public string GetJokeWithWordTwoTimes(string word, IEnumerable<string> jokes)
        {

            foreach (var joke in jokes)
            {
                var firstPosition = joke.IndexOf(word, StringComparison.OrdinalIgnoreCase);
                if (firstPosition == -1) continue;
                var secondPosition = joke.IndexOf(word, firstPosition + 1, StringComparison.OrdinalIgnoreCase);
                if (secondPosition != -1) return joke;
            }

            return null;
        }
    }
}
