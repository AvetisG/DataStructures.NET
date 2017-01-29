using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedListExamples();

            SinglyLinkedListExamples();
        }

        private static void DoublyLinkedListExamples()
        {
            // Example of using DoublyLinkedList and all of its methods
            DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>();

            doublyLinkedList.AddToHead(1).AddToHead(2).AddToHead(3).AddToHead(4).AddToHead(5).Print();
            Console.WriteLine("Count is {0}", doublyLinkedList.Count());
            doublyLinkedList.Clear();

            doublyLinkedList.AddToTail(1).AddToTail(2).AddToTail(3).AddToTail(4).AddToTail(5).Print();
            Console.WriteLine("Count is {0}", doublyLinkedList.Count());
            doublyLinkedList.Clear();

            doublyLinkedList.AddToTail(1).AddToTail(2).AddToTail(3).AddToTail(4).AddToTail(5).AddToPosition(10, 3).AddToPosition(20, 3).Print();
            Console.WriteLine("Count is {0}", doublyLinkedList.Count());
            doublyLinkedList.Clear();

            doublyLinkedList.AddToTail(1).AddToTail(2).AddToTail(3).AddToTail(4).AddToTail(5).AddToPosition(20, 5).Print();
            Console.WriteLine("Count is {0}", doublyLinkedList.Count());
            doublyLinkedList.Clear();

            doublyLinkedList.AddToPosition(10, 0).AddToTail(20).Print();
            Console.WriteLine("Count is {0}", doublyLinkedList.Count());
            doublyLinkedList.Clear();

            doublyLinkedList.AddToTail(1).AddToTail(2).AddToTail(3).AddToTail(4).AddToTail(5).RemoveFromPosition(0).Print();
            Console.WriteLine("Count is {0}", doublyLinkedList.Count());
            doublyLinkedList.Clear();

            doublyLinkedList.AddToTail(1).AddToTail(2).AddToTail(3).AddToTail(4).AddToTail(5).RemoveFromPosition(4).Print();
            Console.WriteLine("Count is {0}", doublyLinkedList.Count());
            doublyLinkedList.Clear();

            doublyLinkedList.AddToTail(1).AddToTail(2).AddToTail(3).AddToTail(4).AddToTail(5).RemoveFromPosition(2).Print();
            Console.WriteLine("Count is {0}", doublyLinkedList.Count());
            doublyLinkedList.Clear();

            doublyLinkedList.AddToTail(1).AddToTail(2).AddToTail(3).AddToTail(4).AddToTail(5);
            Console.WriteLine("Gotten node is {0}", doublyLinkedList.GetNode(4));

            doublyLinkedList.AddToTail(1).AddToTail(2).AddToTail(3).AddToTail(4).AddToTail(5);
            Console.WriteLine(doublyLinkedList.Search(4));
            Console.WriteLine(doublyLinkedList.Search(10));
        }

        private static void SinglyLinkedListExamples()
        {
            // Example of using SinglyLinkedList and all of its methods
            SinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>();

            singlyLinkedList.AddToHead(1).AddToHead(2).AddToHead(3).AddToHead(4).AddToHead(5).Print();
            Console.WriteLine("Count is {0}", singlyLinkedList.Count());
            singlyLinkedList.Clear();

            singlyLinkedList.AddToTail(1).AddToTail(2).AddToTail(3).AddToTail(4).AddToTail(5).Print();
            Console.WriteLine("Count is {0}", singlyLinkedList.Count());
            singlyLinkedList.Clear();

            singlyLinkedList.AddToTail(1).AddToTail(2).AddToTail(3).AddToTail(4).AddToTail(5).AddToPosition(10, 3).AddToPosition(20, 3).Print();
            Console.WriteLine("Count is {0}", singlyLinkedList.Count());
            singlyLinkedList.Clear();

            singlyLinkedList.AddToTail(1).AddToTail(2).AddToTail(3).AddToTail(4).AddToTail(5).AddToPosition(20, 5).Print();
            Console.WriteLine("Count is {0}", singlyLinkedList.Count());
            singlyLinkedList.Clear();

            singlyLinkedList.AddToPosition(10, 0).Print();
            Console.WriteLine("Count is {0}", singlyLinkedList.Count());
            singlyLinkedList.Clear();

            singlyLinkedList.AddToTail(1).AddToTail(2).AddToTail(3).AddToTail(4).AddToTail(5).RemoveFromPosition(4).Print();
            Console.WriteLine("Count is {0}", singlyLinkedList.Count());
            singlyLinkedList.Clear();

            singlyLinkedList.AddToTail(1).AddToTail(2).AddToTail(3).AddToTail(4).AddToTail(5);
            Console.WriteLine("Gotten node is {0}", singlyLinkedList.GetNode(4));

            singlyLinkedList.AddToTail(1).AddToTail(2).AddToTail(3).AddToTail(4).AddToTail(5);
            Console.WriteLine(singlyLinkedList.Search(4));
            Console.WriteLine(singlyLinkedList.Search(10));
        }
    }
}
