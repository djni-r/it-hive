using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{
    class DynamicStack
    {
        Chain head; // points to the last (top) element

        /// <summary>
        /// Adds an element to stack 
        /// by creating new object that contains the value of the element
        /// and the object link that points to the previous object or null.
        /// If the head is null, the stack is empty, so the new element is first
        /// and the link will be now pointing to the bottom of stack, which is null. 
        /// The head will be pointing to the new object with added element. 
        /// </summary>
        /// <param name="element"> element to be added</param>
        public void push(int element)
        {
            var obj = new Chain 
            {
                val = element, // the added element
                link = (head != null) ? head : null // link pointing to what was head before or null
            };

            head = obj; // head pointing to new object
        }

        /// <summary>
        /// Removes the last (top) element
        /// </summary>
        /// <returns>the element just removed</returns>
        public int pop()
        {
            var retValue = back(); // gets the top value

            if(!isEmpty)
                head = head.link; // if it not the last element, head now points to the one before it

            return retValue;
        }

        /// <summary>
        /// Gets the top element
        /// </summary>
        /// <returns>the top element</returns>
        public int back()
        {
            return (head != null) ? head.val : 0; // if not empty, does it
        }

        /// <summary>
        /// Checks whether is empty
        /// </summary>
        public bool isEmpty
        {
            get { return head == null; }
        }

        /// <summary>
        /// Gets the size of the stack
        /// by going through each object with element
        /// and incrementing the return value by one
        /// </summary>
        /// <returns>number of elements</returns>
        public uint size()
        {
            if(!isEmpty)
            {
                Chain obj = head; // new object pointing same direction as head
                uint retValue = 1; // if isn't empty, at least one element is in it
                while (obj.link != null) // while haven't reached the bottom
                {
                    retValue++; // increment return value
                    obj = obj.link; // pointing now to the previus object
                }
                return retValue;
            } 
            else return 0;
        }

    }

    /* new class to create object 
     * for storing the value 
     * and pointing to the previous one.
     * */
    class Chain
    {
        public int val; 
        public Chain link;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //UsingMassStack();

            Console.WriteLine("Please, enter a string:");
            string str = Console.ReadLine();
            
            DisplayString(str);

            Console.ReadKey();
        }

        // displays a string backwards using DynamicStack class
        public static void DisplayString(string str)
        {
            var stck = new DynamicStack();

            for (int i = 0; i < str.Length; i++)
            {
                stck.push((int)str.ElementAt(i));
            }
           
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write((char)stck.pop());
            }
        }

        public static void UsingMassStack()
        {
            var aa = new DynamicStack();

            aa.push(2);
            Console.WriteLine("Added first element");
            Console.WriteLine("Size: {0} \nBack: {1}", aa.size(), aa.back());

            aa.push(3);
            Console.WriteLine("Added second element");
            Console.WriteLine("Size: {0} \nBack: {1}", aa.size(), aa.back());

            aa.push(6);
            Console.WriteLine("Added third element");
            Console.WriteLine("Size: {0} \nBack: {1}", aa.size(), aa.back());

            Console.WriteLine("Removed third element: " + aa.pop());
            Console.WriteLine("Size: {0} \nBack: {1}", aa.size(), aa.back());

            Console.WriteLine("Removed second element: " + aa.pop());
            Console.WriteLine("Size: {0} \nBack: {1}", aa.size(), aa.back());

            Console.WriteLine("Removed first element: " + aa.pop());
            Console.WriteLine("Size: {0} \nBack: {1}", aa.size(), aa.back());

            Console.WriteLine("Tried to remove another element: " + aa.pop());
            Console.WriteLine("Size: {0} \nBack: {1}", aa.size(), aa.back());
        }
    }
}
