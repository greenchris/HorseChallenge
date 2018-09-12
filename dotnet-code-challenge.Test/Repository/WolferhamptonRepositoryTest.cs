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
    }
}
