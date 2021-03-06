﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace LowCouplingToUnitTest
{
    public class ChuckNorrisJokeApi : IJokeService
    {
        public async Task<IEnumerable<string>> SearchForJokes(string word)
        {
            var client = new RestClient("https://api.chucknorris.io");
            var request = new RestRequest($"/jokes/search?query={word}", DataFormat.Json);
            var result = await client.GetAsync<ChuckNorrisJokeSearchResultSet>(request);
            return result.result.Select(jokeObj => jokeObj.value);
        }
    }
}
