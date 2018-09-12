using System;
using System.Collections.Generic;
using System.Text;
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
        public IEnumerable<Horse> GetHorses()
        {
            // TODO - create json data loader in data access layer
            throw new NotImplementedException();
        }
    }
}
