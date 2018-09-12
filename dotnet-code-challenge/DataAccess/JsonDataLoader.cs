using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
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
            var jsonString = File.ReadAllText(filePath);
            dynamic data = JsonConvert.DeserializeObject<dynamic>(jsonString);


            return horses;
        }
    }
}
