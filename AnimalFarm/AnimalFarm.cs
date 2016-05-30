using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AnimalFarm
{
    class AnimalFarm : IAnimal
    {
        // stores animals by name
        SortedList<string, Animal> animalsList;
        
        // initializes hashtable
        public AnimalFarm()
        {
            animalsList = new SortedList<string, Animal>();
        }
        // adds an animal to hashtable by name key
        public void Add(Animal animal)
        {
            animalsList.Add(animal.Name, animal);
        }
        // removes an animal by name
        public void Remove(string name)
        {
            animalsList.Remove(name);
        }
        // removes animal with that name and adds a new one instead
        public void Update(Animal animal)
        {
            Remove(animal.Name);
            Add(animal);
        }
        // searches an animal by name, displays its info, and returns true if found
        public bool Search(string name)
        {
            if (animalsList.ContainsKey(name))
            {
                animalsList[name].DisplayInfo();
                return true;
            }
            else return false;

        }
        // searches an animal by type, displays info, and returns true if found
        public bool Search(Type animalType)
        {
            bool ret = false;
            foreach (var animal in animalsList)
                if (animal.Value.GetType() == animalType)
                {
                    animal.Value.DisplayInfo();
                    ret = true;
                }
            return ret;
        }
        // displays information of all animals
        public void DisplayAll()
        {
            foreach (var animal in animalsList)
                animal.Value.DisplayInfo();
        }
    }
}
