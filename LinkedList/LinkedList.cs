using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedList : IEnumerable<int>, IEnumerator<int>
    {
        Node head;
        Node cursor;
        
        public void Add(int value)
        {
            Node element = new Node();
            element.val = value;
            if (head != null)
                element.pointer = head;
            
            head = element;
        }

        public int Remove()
        {
            int retVal = head.val;
            head = head.pointer; 
            return retVal;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            return (IEnumerator<int>)this;
        }

        public int Current
        {
            get 
            {
                if (cursor != null)
                    return cursor.val;
                else return 0;
            }
        }

        public bool MoveNext()
        {
            if (cursor == null)
            {
                cursor = head;
                return true;
            }
            else if (cursor.pointer == null)
                return false;
            else
            {
                cursor = cursor.pointer;
                return true;
                 
            }                
        }

        public void Reset()
        {
            cursor = null;
        }

        public void Dispose()
        {
            cursor = null;
        }
        


        object IEnumerator.Current
        {
            get { throw new NotImplementedException(); }
        }
    }
}
