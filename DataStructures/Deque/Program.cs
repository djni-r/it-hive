using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    class Deque
    {
        Chain head; // points to the first element
        Chain tail; // points to the last element

            
        /// <summary>
        /// Adds an element to the deque from the end 
        /// by creating new object that contains the value of the element
        /// and two links to the element in front of it, and once another is added,
        /// to the new one after it.
        /// Removes an element from the front. 
        /// </summary>
        /// <param name="element"> element to be added</param>
        public void push_back(int element)
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

        // same as push_back but from the other side
        public void push_front(int element)
        {
            var obj = new Chain
            {
                val = element,
                headLink = (head != null) ? head : null,
                tailLink = null,
            };

            if (tail == null) tail = obj;
            if (head != null) head.tailLink = obj;
            head = obj;
        }

        /// <summary>
        /// Removes the first element
        /// </summary>
        /// <returns>the element just removed</returns>
        public int pop_front()
        {
            var retValue = front(); // gets the front value

            if (!isEmpty)
                head = head.headLink; // if deque is not empty, head now points to the element before it or is null

            if (head != null) head.tailLink = null; // head's tailLink is always null
            else tail = null; // if head is null, tail should be null too
            return retValue;
        }

        // same as pop_front but from the other side
        public int pop_back()
        {
            var retValue = back();

            if (!isEmpty)
                tail = tail.tailLink;

            if (tail != null) tail.headLink = null;
            else head = null;
            return retValue;
        }

        /// <summary>
        /// Gets the first element in the deque
        /// </summary>
        /// <returns>the front element</returns>
        public int front()
        {
            return (head != null) ? head.val : 0; // if not empty, does it
        }

        /// <summary>
        /// Gets the last element in the deque
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
        /// Gets the size of the deque
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
            UsingDeque();

            Console.ReadKey();
        }

        // check whether everything works fine
        public static void UsingDeque()
        {
            var aa = new Deque();
            int n = 5;

            // add elements from both sides
            for (int i = 1; i <= 5 * n; i += 5)
            {
                aa.push_front(i);
                Console.WriteLine("\nAdded {0} from the front", i);
                Console.WriteLine("\nSize: {0} \tBack: {1} \tFront: {2}\n", aa.size(), aa.back(), aa.front());

                aa.push_back(i + 7);
                Console.WriteLine("Added {0} from the back", i + 7);
                Console.WriteLine("\nSize: {0} \tBack: {1} \tFront: {2}\n", aa.size(), aa.back(), aa.front());
            }

            // remove elements from both sides
            for (int i = 0; i <= 5 * n; i += 5) // i <= ... to check what happens when try to remove elements from empty deque
            {
                Console.WriteLine("Removed {0} from the front", aa.pop_front());
                Console.WriteLine("\nSize: {0} \tBack: {1} \tFront: {2}\n", aa.size(), aa.back(), aa.front());

                Console.WriteLine("Removed {0} from the back", aa.pop_back());
                Console.WriteLine("\nSize: {0} \tBack: {1} \tFront: {2}\n", aa.size(), aa.back(), aa.front());
            }
        }
    }
}


