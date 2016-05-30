using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data_Structures
{
    class Queue
    {
        Chain head; // points to the first element
        Chain tail; // points to the last element

        /// <summary>
        /// Adds an element to the queue from the end 
        /// by creating new object that contains the value of the element
        /// and two links to the element in front of it, and once another is added,
        /// to the new one after it.
        /// Removes an element from the front. 
        /// </summary>
        /// <param name="element"> element to be added</param>
        public void push(int element)
        {
            
            var obj = new Chain
            {
                val = element, // the added element
                tailLink = (tail != null) ? tail : null, // link pointing to what was tail before or null
                headLink = null, // new object's headLink will be changed when another one is added
            };
            
            if (head == null) head = obj; 
            if (tail != null) tail.headLink = obj; // previous object, which is tail until next statement,
                                                    // now points to the new object to be tail afte next statement
            tail = obj; // here
        }

        /// <summary>
        /// Removes the first element
        /// </summary>
        /// <returns>the element just removed</returns>
        public int pop()
        {
            var retValue = front(); // gets the front value

            if (!isEmpty)
                head = head.headLink; // if queue is not empty, head now points to the element before it or is null

            if (head != null) head.tailLink = null; // head's tailLink is always null
            else tail = null; // if head is null, tail should be null too
            return retValue;
        }

        /// <summary>
        /// Gets the first element in the queue
        /// </summary>
        /// <returns>the front element</returns>
        public int front()
        {
            return (head != null) ? head.val : 0; // if not empty, does it
        }
        /// <summary>
        /// Gets the last element in the queue
        /// </summary>
        /// <returns>it</returns>
        public int back()
        {
            return (tail != null) ? tail.val : 0;
        }

        /// <summary>
        /// Checks whether is empty
        /// </summary>
        public bool isEmpty
        {
            get { return tail == null && head == null; } // if one is null the other is too
        }

        /// <summary>
        /// Gets the size of the queue
        /// by going through each object with element
        /// and incrementing the return value by one
        /// </summary>
        /// <returns>number of elements</returns>
        public uint size()
        {
            if (!isEmpty)
            {
                Chain obj = tail; // new object pointing same direction as tail
                uint retValue = 1; // if isn't empty, at least one element is in it
                while (obj.tailLink != null) // while haven't reached the front
                {
                    retValue++; // increment return value
                    obj = obj.tailLink; // pointing now to the object in front of it
                }
                return retValue;
            }
            else return 0;
        }

    }

    /* new class to create object 
     * for storing the value 
     * and links to the elements
     * in front of it and after it
     */
    class Chain
    {
        public int val;
        public Chain headLink;
        public Chain tailLink;
    }

    class Program
    {
        static void Main(string[] args)
        {
            UsingMassStack();

            Console.ReadKey();
        }

        // check whether everything works fine
        public static void UsingMassStack()
        {
            var aa = new Queue();

            aa.push(2);
            Console.WriteLine("\nAdded 2 --------------------------------");
            Console.WriteLine("\nSize: {0} \tBack: {1} \tFront: {2}\n", aa.size(), aa.back(), aa.front());

            aa.push(3);
            Console.WriteLine("Added 3 --------------------------------");
            Console.WriteLine("\nSize: {0} \tBack: {1} \tFront: {2}\n", aa.size(), aa.back(), aa.front());

            aa.push(6);
            Console.WriteLine("Added 6 --------------------------------");
            Console.WriteLine("\nSize: {0} \tBack: {1} \tFront: {2}\n", aa.size(), aa.back(), aa.front());

            Console.WriteLine("Removed {0} ------------------------------", aa.pop());
            Console.WriteLine("\nSize: {0} \tBack: {1} \tFront: {2}\n", aa.size(), aa.back(), aa.front());

            Console.WriteLine("Removed {0} ------------------------------", aa.pop());
            Console.WriteLine("\nSize: {0} \tBack: {1} \tFront: {2}\n", aa.size(), aa.back(), aa.front());

            Console.WriteLine("Removed {0} ------------------------------", aa.pop());
            Console.WriteLine("\nSize: {0} \tBack: {1} \tFront: {2}\n", aa.size(), aa.back(), aa.front());

            Console.WriteLine("Tried to remove another element --------", aa.pop());
            Console.WriteLine("\nSize: {0} \tBack: {1} \tFront: {2}\n", aa.size(), aa.back(), aa.front());
        }
    }
}

