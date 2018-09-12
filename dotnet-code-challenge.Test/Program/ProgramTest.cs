using System.Linq;
using Xunit;

namespace dotnet_code_challenge.Test.Program
{
    public class ProgramTest
    {
        [Fact]
        public void GivenWolferhamptonDataFeedWithTwoHorses_WhenGetHorsesInOrder_ThenShouldSucceed()
        {
            // arrange, act, assert
            var expectedFirstHorseId = "2";
            var expectedSecondHorseId = "1";

            var horses = dotnet_code_challenge.Program.GetHorsesInOrder().ToList();
            var actualFirstHorseId = horses.First().Id;
            var actualSecondHorseId = horses.Last().Id;

            Assert.Equal(expectedFirstHorseId, actualFirstHorseId);
            Assert.Equal(expectedSecondHorseId, actualSecondHorseId);
        }
    }
}
