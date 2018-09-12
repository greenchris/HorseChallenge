using System.Collections.Generic;
using dotnet_code_challenge.Model;

namespace dotnet_code_challenge.Repository.Contracts
{
    public interface IRaceRepository
    {
        IEnumerable<Horse> GetHorses();
    }
}