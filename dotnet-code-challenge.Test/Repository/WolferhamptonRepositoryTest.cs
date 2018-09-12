using System.Linq;
using Xunit;

namespace dotnet_code_challenge.Test.Repository
{
    public class WolferhamptonRepositoryTest : BaseRepositoryTest
    {
        [Fact]
        public void GivenWolferhamptonRepositoryWithTwoHorses_WhenRetrievalOfHorses_ThenShouldGetTwoHorses()
        {
            // arrange, act, assert
            var repo = CreateWolferhamptonRepository();
            var expectedNumberOfHorses = 2;

            var actualNumberOfHorses = repo.GetHorses().Count();

            Assert.Equal(expectedNumberOfHorses, actualNumberOfHorses);
        }

        [Fact]
        public void GivenWolferhamptonRepositoryWithTwoHorses_WhenRetrievalOfHorses_ThenShouldSucceedWithExpectedHorseIds()
        {
            // arrange, act, assert
            var repo = CreateWolferhamptonRepository();
            var expectedFirstHorseId = "1";
            var expectedSecondHorseId = "2";

            var actualFirstHorseId = repo.GetHorses().First().Id;
            var actualSecondHorseId = repo.GetHorses().Last().Id;

            Assert.Equal(expectedFirstHorseId, actualFirstHorseId);
            Assert.Equal(expectedSecondHorseId, actualSecondHorseId);
        }
    }
}
