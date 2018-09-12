using System.Collections.Generic;
using dotnet_code_challenge.DataAccess;
using dotnet_code_challenge.Model;
using dotnet_code_challenge.Repository.Contracts;

namespace dotnet_code_challenge.Repository
{
    /// <summary>
    /// Repository that abstracts away data access for retrieving Horses from the 
    /// Wolferhampton race 
    /// </summary>
    public class WolferhamptonRaceRepository : IRaceRepository
    {
        private static readonly JsonDataLoader JsonDataLoader = new JsonDataLoader();

        public IEnumerable<Horse> GetHorses()
        {
            return JsonDataLoader.LoadWolferHamptonHorses();
        }
    }
}
