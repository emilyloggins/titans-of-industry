using System;

namespace titan_of_industry
{
    class Program
    {
        static void Main(string[] args)
        {
            Confectioner JohnDoe = new Confectioner() {
                Name = "John Doe"
            };

            TaffyFactory Wonka = new TaffyFactory() {
                MinimumWorkers = 200,
                MaximumWorkers = 500
            };

            Wonka.HireEmployee(JohnDoe);

            foreach (string w in Wonka.TaffyEmployees)
            {
            Console.WriteLine($"{w}");
            }
        }
    }
}
