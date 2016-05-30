using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    // initialize animals
    abstract class Animal
    {
        public Animal(string name, uint age, char sex)
        {
            Name = name;
            Age = age;
            sex = char.ToLower(sex);
            if (sex != 'm' && sex != 'f')
                Sex = '-';
            else Sex = sex;
        }

        // animals info
        public abstract Type ShowType();
        public string Name { private set; get; }
        public uint Age { private set; get; }
        public char Sex { private set; get; }

        // display info
        public void DisplayInfo()
        {
            Console.WriteLine("{0} - {1,10}  - {2,2}  - {3,3} years old", ShowType(), Name, Sex, Age);
        }
    }
}
