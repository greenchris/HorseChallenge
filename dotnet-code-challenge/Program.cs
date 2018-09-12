using System;
using System.Linq;
using dotnet_code_challenge.Repository;

namespace dotnet_code_challenge
{
    public class Program
    {
        /// <summary>
        /// A Console App to output horse names from a data feed in ascending order of price.
        /// </summary>
        static void Main(string[] args)
        {
            // create horse race repos
            var wolferHamptonRepo = new WolferhamptonRaceRepository();

            // retrieve the horses, and order them by price ascending
            var horses = wolferHamptonRepo.GetHorses().OrderBy(h => h.Price);

            // output the horse names in the console
            Console.WriteLine("Horses Names in Price ascending Order:\n");

            foreach (var horse in horses)
            {
                Console.WriteLine(horse.Name);
            }

            Console.ReadKey();
        }
    }
}
