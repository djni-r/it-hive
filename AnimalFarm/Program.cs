using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            // init new farm to work with
            AnimalFarm farm = new AnimalFarm();
            
            // add new dogs and cats from file
            FileReader.AddDogs(5, farm);
            FileReader.AddCats(7, farm);

            Console.WriteLine("\nSearch for Kitty\n");
            farm.Search("Kitty");
            Console.WriteLine("\nSearch for Sphinx\n");
            farm.Search("Sphinx");
            
            Console.WriteLine("\nSearch for dogs:\n");
            farm.Search(typeof(Dog));

            Console.WriteLine("\nRemoving Sir");
            farm.Remove("Sirr");
            
            // init new dog to add
            Dog newDog = new Dog("Jabber", 16, 'M');
            Console.WriteLine("Adding Jabber");
            farm.Add(newDog);

            // init new dog to update 
            Dog Hero = new Dog("Hero", 11, 'm');
            Console.WriteLine("Updating Hero");
            farm.Update(Hero);
            
            Console.WriteLine("\nAll animals:\n");
            farm.DisplayAll();

        }
    }
}
