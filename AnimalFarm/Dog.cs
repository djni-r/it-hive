using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    class Dog : Animal
    {
        public Dog(string name, uint age, char sex) : base(name, age, sex) { }
        
        public override Type ShowType()
        {
            return this.GetType();
        }

    }
}
