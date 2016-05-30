using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit8
{
    class MassStack
    {
        int[] mass;

        int head;

        public MassStack()
        {
            mass = new int[10];

            head = 0;
        }

        /// <summary>
        /// Добавить элемент
        /// </summary>
        /// <returns></returns>
        public void push(int element)
        {
            mass[head++] = element;
        }

        /// <summary>
        /// Удалить элемент и вернуть его значение
        /// </summary>
        public int pop()
        {
            var retValue = back();

            if (head > 0)
                head--;

            return retValue;
        }

        /// <summary>
        /// Узнать значение последнего добавленного элемента
        /// </summary>
        /// <returns></returns>
        public int back()
        {
            return (head > 0) ? mass[head - 1] : 0;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool isEmpty
        {
            get { return (head == 0) ? true : false; }
        }

        /// <summary>
        /// Узнать размер стэка
        /// </summary>
        /// <returns></returns>
        public uint size()
        {
            return (uint)head;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            UsingMassStack();

            Console.ReadKey();
        }

        public static void UsingMassStack()
        {
            var aa = new MassStack();

            aa.push(2);
            Console.WriteLine("Added 1 element");
            Console.WriteLine("Size: {0} \nBack: {1}", aa.size(), aa.back());

            aa.push(3);
            Console.WriteLine("Added 2 element");
            Console.WriteLine("Size: {0} \nBack: {1}", aa.size(), aa.back());

            aa.push(6);
            Console.WriteLine("Added 3 element");
            Console.WriteLine("Size: {0} \nBack: {1}", aa.size(), aa.back());

            aa.pop();
            Console.WriteLine("Removed 1 element");
            Console.WriteLine("Size: {0} \nBack: {1}", aa.size(), aa.back());

            aa.pop();
            Console.WriteLine("Removed 2 element");
            Console.WriteLine("Size: {0} \nBack: {1}", aa.size(), aa.back());

            aa.pop();
            Console.WriteLine("Removed 3 element");
            Console.WriteLine("Size: {0} \nBack: {1}", aa.size(), aa.back());
        }
    }
}
