using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AnimalFarm
{
    class FileReader
    {

        public static void AddDogs(uint amount, AnimalFarm farm)
        {
            Dog[] dogs = new Dog[amount];
            // go through all dogs to give them name, age, and sex, and add them to farm if file's input is correct
            try
            {
                for (int i = 0, j = 0; i < amount; i++, j += 3)
                {
                    dogs[i] = new Dog(File.ReadLines("DogsFile.txt").ElementAt(j),
                        uint.Parse(File.ReadLines("DogsFile.txt").ElementAt(j + 1)),
                        char.Parse(File.ReadLines("DogsFile.txt").ElementAt(j + 2))) ;
                    farm.Add(dogs[i]);
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("DogsFile.txt contains incorrect input. \nUsage: \nName \nAge \nSex[m/f]. \n\nExample: \nSir \n5 \nm");
            }
        }
        
        public static void AddCats(uint amount, AnimalFarm farm)
        {
            Cat[] cats = new Cat[amount];
            // go through all cats to give them name, age, and sex, and add them to farm if file's input is correct
            try
            {
                for (int i = 0, j = 0; i < amount; i++, j += 3)
                {
                    cats[i] = new Cat(File.ReadLines("CatsFile.txt").ElementAt(j),
                        uint.Parse(File.ReadLines("CatsFile.txt").ElementAt(j + 1)),
                        char.Parse(File.ReadLines("CatsFile.txt").ElementAt(j + 2)));
                    farm.Add(cats[i]);
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("CatsFile.txt contains incorrect input. \nUsage: \nName \nAge \nSex[m/f]. \n\nExample: \nShishir \n5 \nm");
            }
        }
    }
}
