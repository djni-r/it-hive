using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    interface IAnimal
    {
        void Add(Animal animal);
        void Remove(string name);
        void Update(Animal animal);
        bool Search(Type animalType);
        bool Search(string name);
    }
}
