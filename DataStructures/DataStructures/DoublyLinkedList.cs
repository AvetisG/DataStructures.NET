using System;

namespace DataStructures
{
    class DoublyLinkedList<T>
    {
        private DoublyLinkedListNode<T> _head;
        private int _count;

        public DoublyLinkedList<T> AddToHead(T Data)
        {
            var newNode = new DoublyLinkedListNode<T>(Data, null);

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
        public DoublyLinkedListNode(T argData, DoublyLinkedListNode<T> argPrevious)
        {
            Data = argData;
            Previous = argPrevious;
        }

        public T Data { get; set; }
        public DoublyLinkedListNode<T> Next { get; set; }
        public DoublyLinkedListNode<T> Previous { get; set; }
    }
}
