
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;

namespace LowCouplingToUnitTest.UnitTest
{
    public class JokeGeneratorUnitTest
    {
        [Test]
        public async Task Test1()
        {
            // Arrange 
            var jokeServiceMock = new Mock<IJokeService>();
            jokeServiceMock.Setup(jsm => jsm.SearchForJokes(It.IsAny<string>()))
                .ReturnsAsync(new[]
                {
                    "aaa bbb",
                    "ccc bbb",
                    "aaa aaa",
                    "aaa aaa zzz",
                });

            // Act
            var jokeGenerator = new JokeGenerator(jokeServiceMock.Object);
            var joke = await jokeGenerator.GetJokeWithWordTwoTimes("aaa");

            // Assert
            Assert.AreEqual("aaa aaa", joke);
        }
    }
}