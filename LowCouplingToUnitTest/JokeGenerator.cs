using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace LowCouplingToUnitTest
{
    public class JokeGenerator
    {
        private readonly IJokeService _jokeService;

        public JokeGenerator(IJokeService jokeService)
        {
            _jokeService = jokeService;
        }

        public async Task<string> GetJokeWithWordTwoTimes(string word)
        {
            //var client = new RestClient("https://api.chucknorris.io");
            //var request = new RestRequest($"/jokes/search?query={word}", DataFormat.Json);
            //var result = await client.GetAsync<ChuckNorrisJokeSearchResultSet>(request);
            var jokes = await _jokeService.SearchForJokes(word);

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
