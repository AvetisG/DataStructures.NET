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

        public SinglyLinkedList<T> AddToHead(T argData)
        {
            var newNode = new SinglyLinkedListNode<T>(argData);

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

        public SinglyLinkedList<T> AddToTail(T argData)
        {
            var newNode = new SinglyLinkedListNode<T>(argData);

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

        public SinglyLinkedList<T> AddToPosition(T argData, int argInsertionPosition)
        {
            CheckRanges(argInsertionPosition);

            var newNode = new SinglyLinkedListNode<T>(argData);
            if (_head == null)
            {
                _head = newNode;
            }
            else
            {
                var currentPosition = 0;
                var currentNode = _head;

                // We want to get the previous node from the position of the node that we want to make the insertion at
                while (currentPosition < argInsertionPosition - 1)
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

        public SinglyLinkedList<T> RemoveFromPosition(int argRemovalPosition)
        {
            // We increment since we don't want it to remove the tail - there is nothing to remove there
            CheckRanges(argRemovalPosition + 1);

            var currentPosition = 0;
            var currentNode = _head;

            while (currentPosition < argRemovalPosition - 1)
            {
                currentPosition++;
                currentNode = currentNode.Next;
            }

            var nodeToStoreForRemoval = currentNode.Next;
            currentNode.Next = nodeToStoreForRemoval.Next;

            _count--;
            return this;
        }

        public T GetNode(int argRetrievalPosition)
        {
            CheckRanges(argRetrievalPosition);

            var currentPosition = 0;
            var currentNode = _head;

            while (currentPosition < argRetrievalPosition)
            {
                currentPosition++;
                currentNode = currentNode.Next;
            }

            return currentNode != null ? currentNode.Data : default(T);
        }

        private void CheckRanges(int argPosition)
        {
            if (argPosition < 0) throw new IndexOutOfRangeException("An index cannot be negative");
            if (argPosition > _count) throw new IndexOutOfRangeException("The current position is out of the range.");
        }

        public bool Search(T argData)
        {
            var currentNode = _head;

            while (currentNode != null) {
                if (currentNode.Data.Equals(argData)) return true;
                currentNode = currentNode.Next;
            }
            
            return false;
        }

        public SinglyLinkedList<T> Print()
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

            return this;
        }

        public SinglyLinkedList<T> Clear()
        {
            _head = null;
            _count = 0;

            return this;
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

        public SinglyLinkedListNode<T> Next { get; set; }
        public T Data { get; set; }
    }
}
