using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LowCouplingToUnitTest
{
    public interface IJokeService
    {
        Task<IEnumerable<string>> SearchForJokes(string word);
    }
}
