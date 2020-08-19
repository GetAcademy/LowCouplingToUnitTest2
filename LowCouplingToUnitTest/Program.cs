using System;
using System.Threading.Tasks;

namespace LowCouplingToUnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync().Wait();
        }

        static async Task MainAsync()
        {
            var chuckNorrisJokeApi = new ChuckNorrisJokeApi();
            var generator = new JokeGenerator(chuckNorrisJokeApi);
            //var jokeFetcher = new JokeFetcher();
            //var jokeSearch = new JokeSearch();
            while (true)
            {
                Console.Write("Hvilket ord vil du at vitsene skal ha to av? ");
                var  word = Console.ReadLine();
                var joke = await generator.GetJokeWithWordTwoTimes(word);
                //var jokes = await jokeFetcher.GetJokes(word);
                //var joke = jokeSearch.GetJokeWithWordTwoTimes(word, jokes);
                Console.WriteLine(joke ?? $"Fant ingen vitser med ordet \"{word}\" to ganger.");
            }
        }
    }
}
