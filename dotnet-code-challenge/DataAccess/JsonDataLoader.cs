using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using dotnet_code_challenge.Model;
using Newtonsoft.Json.Linq;

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
            var rawData = data["RawData"];

            var participants = rawData["Participants"];
            if (participants != null)
            {
                var markets = rawData["Markets"];
                var selections = ((JArray)markets).Select(m => m["Selections"]);
                var selectionItems = selections.SelectMany(si => si);
                var marketSelections = selectionItems.Select(s => new MarketSelection
                {
                    Id = (string)s["Id"],
                    Price = (decimal)s["Price"],
                    ParticipantId = (string)s["Tags"]["participant"]
                }).ToArray();


            }

            return horses;
        }
    }
}
