using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class SinglyLinkedList<T>
    {
        private SinglyLinkedListNode<T> _head;
        private int _count;

        public SinglyLinkedList<T> AddToHead(T Data)
        {
            var newNode = new SinglyLinkedListNode<T>(Data);

            if (_head == null)
            {
                _head = newNode;
            }
            else
            {
                /*
                 The reason why we need to reasign _head is because newNode is pointing from a stack to an element that
                 the _head has no access to. So we need the head to become the newNode in order to have access to the whole thing.
                 */
                newNode.Next = _head;
                _head = newNode;
            }

            _count++;
            return this;
        }

        public SinglyLinkedList<T> AddToTail(T Data)
        {
            var newNode = new SinglyLinkedListNode<T>(Data);

            if (_head == null)
            {
                _head = newNode;
            }
            else
            {
                var currentNode = _head;

                while (currentNode.Next != null) currentNode = currentNode.Next;

                /*
                 In this case we don't need to reasign head since the currentNode is referencing the same object and
                 when it gets to the end and adds newNode the _head will still have access to it all.
                 */
                currentNode.Next = newNode;
            }

            _count++;
            return this;
        }

        public SinglyLinkedList<T> AddToPosition(T Data, int insertPosition)
        {
            if (insertPosition < 0) throw new IndexOutOfRangeException("An index cannot be negative");
            if (insertPosition > _count + 1) throw new IndexOutOfRangeException("The current insertion position is out of the range.");

            var newNode = new SinglyLinkedListNode<T>(Data);
            if (_head == null && insertPosition == 0)
            {
                _head = newNode;
            }
            else
            {
                int currentPosition = 0;
                var currentNode = _head;

                // We want to get the previous node from the position of the node that we want to make the insertion at
                while (currentPosition < insertPosition - 1)
                {
                    currentPosition++;
                    currentNode = currentNode.Next;
                }

                var nodeToStoreAndMoveAtInsertionPosition = currentNode.Next;
                currentNode.Next = newNode;
                newNode.Next = nodeToStoreAndMoveAtInsertionPosition;
            }
            
            _count++;
            return this;
        }
        
        public void Print()
        {
            var currentNode = _head;

            while (currentNode != null)
            {
                if (currentNode.Next != null)
                {
                    Console.Write("{0} -> ", currentNode.Data);
                }
                else
                {
                    Console.WriteLine("{0} -> NULL", currentNode.Data);
                }

                currentNode = currentNode.Next;
            }
        }

        public void Clear()
        {
            _head = null;
        }

        public int Count()
        {
            return _count;
        }
    }

    class SinglyLinkedListNode<T>
    {
        public SinglyLinkedListNode(T argData)
        {
            Data = argData;
        }

        public SinglyLinkedListNode<T> Next;
        public T Data { get; set; }
    }
}
