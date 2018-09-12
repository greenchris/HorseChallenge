using System.Collections.Generic;
using System.Linq;
using dotnet_code_challenge.Model;

namespace dotnet_code_challenge.DataAccess
{
    public class JsonDataLoader
    {
        private static readonly string filePath = @"FeedData\Wolferhampton_Race1.json";

        /// <summary>
        /// Retrieves Race Horses from a Wolferhampton Race and 
        /// projects them as Horses
        /// </summary>
        public IEnumerable<Horse> LoadWolferHamptonHorses()
        {
            var horses = Enumerable.Empty<Horse>();

            // TODO - do stuff!!

            return horses;
        }
    }
}
