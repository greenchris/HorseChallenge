using System;
using System.Collections.Generic;
using System.Linq;
using dotnet_code_challenge.Model;
using dotnet_code_challenge.Repository;

namespace dotnet_code_challenge
{
    public class Program
    {
        private static readonly WolferhamptonRaceRepository WolferHamptonRepo = new WolferhamptonRaceRepository();

        /// <summary>
        /// A Console App to output horse names from a data feed in ascending order of price.
        /// </summary>
        static void Main(string[] args)
        {
            // retrieve the horses, and order them by price ascending
            var horses = GetHorsesInOrder();

            // output the horse names in the console
            Console.WriteLine("Horses Names in Price ascending Order:\n");

            foreach (var horse in horses)
            {
                Console.WriteLine(horse.Name);
            }

            Console.ReadKey();
        }

        public static IEnumerable<Horse> GetHorsesInOrder()
        {
            return WolferHamptonRepo.GetHorses().OrderBy(h => h.Price);
        }
    }
}
