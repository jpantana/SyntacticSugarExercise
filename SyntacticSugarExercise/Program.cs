using SyntacticSugarExercise.Bugs;
using System;
using System.Collections.Generic;

namespace SyntacticSugarExercise
{
    class Program
    {
        private const string Separator = ", ";

        static void Main(string[] args)
        {

            List<string> predators = new List<string>();
            List<string> preys = new List<string>();

            var whatKindaBug = "Beetle";

            var newBug = new Bug("John", "fly", predators, preys);

            Console.WriteLine($"What are some predators of a {whatKindaBug}?");
            var somePredators = Console.ReadLine();

            string[] predatorStringList = somePredators.Split(", ");

            foreach (var predator in predatorStringList)
            {
                newBug.PredatorList();
                predators.Add(predator);
            }

            Console.WriteLine($"What are some 'prey' for the {whatKindaBug}");
            var somePrey = Console.ReadLine();

            string[] preyStringList = somePrey.Split(", ");

            foreach (var prey in preyStringList)
            {
                newBug.PreyList();
                preys.Add(prey);
            }

        }
    }
}
