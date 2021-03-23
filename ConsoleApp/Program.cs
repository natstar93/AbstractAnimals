using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var fluffy = new Dog() {Name = "Fluffy"};
            var piggy = new GuineaPig() {Name = "Piggles"};

            Console.WriteLine($"\nHello {fluffy.Name}");
            Console.WriteLine(fluffy.Bark());

            Console.WriteLine($"\nHello {piggy.Name}");
            Console.WriteLine(piggy.Squeak());

            Console.WriteLine("\nWhat's for lunch?");

            Console.WriteLine($"\nI like {piggy.DietaryRequirements()} food");
            Console.WriteLine($"\nI like {fluffy.DietaryRequirements()}");
        }
    }
}
