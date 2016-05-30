using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var LL = new LinkedList();
            LL.Add(5);
            LL.Add(8);
            LL.Add(1);
            
            foreach (var i in LL)
                Console.WriteLine(i);

            Console.WriteLine("\nRemoved: " + LL.Remove());
            foreach (var i in LL)
                Console.WriteLine(i);
        }
    }
}
