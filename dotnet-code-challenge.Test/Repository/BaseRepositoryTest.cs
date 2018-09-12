using dotnet_code_challenge.Repository;

namespace dotnet_code_challenge.Test.Repository
{
    public class BaseRepositoryTest
    {
        protected WolferhamptonRaceRepository CreateWolferhamptonRepository()
        {
            return new WolferhamptonRaceRepository();
        }
    }
}
