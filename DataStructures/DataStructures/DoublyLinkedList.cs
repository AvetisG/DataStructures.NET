using System;

namespace DataStructures
{
    class DoublyLinkedList<T>
    {
        private DoublyLinkedListNode<T> _head;
        private int _count;

        public DoublyLinkedList<T> AddToHead(T argData)
        {
            var newNode = new DoublyLinkedListNode<T>(argData);

            if (_head == null)
            {
                _head = newNode;
            } 
            else
            {
                newNode.Next = _head;
                _head.Previous = newNode;
                _head = newNode;
            }

            _count++;
            return this;
        }

        public DoublyLinkedList<T> AddToTail(T argData)
        {
            var newNode = new DoublyLinkedListNode<T>(argData);

            if (_head == null)
            {
                _head = newNode;
            }
            else
            {
                var currentNode = _head;

                while (currentNode.Next != null) currentNode = currentNode.Next;

                newNode.Previous = currentNode;
                currentNode.Next = newNode;
            }

            _count++;
            return this;
        }

        public DoublyLinkedList<T> AddToPosition(T argData, int argInsertionPosition)
        {
            CheckRanges(argInsertionPosition);
            
            var newNode = new DoublyLinkedListNode<T>(argData);
            if (_head == null)
            {
                _head = newNode;
            }
            else if (argInsertionPosition == 0)
            {
                newNode.Next = _head;
                _head.Previous = newNode;
                _head = newNode;
            }
            else if (argInsertionPosition == _count)
            {
                var currentNode = _head;
                while (currentNode.Next != null) currentNode = currentNode.Next;

                newNode.Previous = currentNode;
                currentNode.Next = newNode;
            }
            else
            {
                var currentPosition = 0;
                var currentNode = _head;
                
                while (currentPosition < argInsertionPosition)
                {
                    currentPosition++;
                    currentNode = currentNode.Next;
                }

                var currentNodePrevious = currentNode.Previous;

                currentNodePrevious.Next = newNode;
                newNode.Previous = currentNodePrevious;

                newNode.Next = currentNode;
                currentNode.Previous = newNode;
            }

            _count++;
            return this;
        }

        public DoublyLinkedList<T> RemoveFromPosition(int argRemovalPosition)
        {
            // We increment since we don't want it to remove the tail - there is nothing to remove there
            CheckRanges(argRemovalPosition + 1);

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

            while (currentNode != null)
            {
                if (currentNode.Data.Equals(argData)) return true;
                currentNode = currentNode.Next;
            }

            return false;
        }

        public DoublyLinkedList<T> Print()
        {
            var currentNode = _head;
            var isHead = true;

            while (currentNode != null)
            {
                if (isHead)
                {
                    Console.Write("NULL <- ");
                    isHead = false;
                }

                if (currentNode.Next != null)
                {
                    Console.Write("{0} <-> ", currentNode.Data);
                }
                else
                {
                    Console.WriteLine("{0} -> NULL", currentNode.Data);
                }

                currentNode = currentNode.Next;
            }

            return this;
        }

        public DoublyLinkedList<T> Clear()
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

    class DoublyLinkedListNode<T>
    {
        public DoublyLinkedListNode(T argData)
        {
            Data = argData;
        }

        public T Data { get; set; }
        public DoublyLinkedListNode<T> Next { get; set; }
        public DoublyLinkedListNode<T> Previous { get; set; }
    }
}
