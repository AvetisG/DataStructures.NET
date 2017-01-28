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
            // Example of using SinglyLinkedList and all of its methods

            SinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>();

            singlyLinkedList.AddToHead(1).AddToHead(2).AddToHead(3).AddToHead(4).AddToHead(5).Print().Count();
            singlyLinkedList.Clear();

            singlyLinkedList.AddToTail(1).AddToTail(2).AddToTail(3).AddToTail(4).AddToTail(5).Print().Count();
            singlyLinkedList.Clear();

            singlyLinkedList.AddToTail(1).AddToTail(2).AddToTail(3).AddToTail(4).AddToTail(5).AddToPosition(10, 3).AddToPosition(20, 3).Print().Count();
            singlyLinkedList.Clear();

            singlyLinkedList.AddToTail(1).AddToTail(2).AddToTail(3).AddToTail(4).AddToTail(5).RemoveFromPosition(3).Print();
            singlyLinkedList.Clear();

            singlyLinkedList.AddToTail(1).AddToTail(2).AddToTail(3).AddToTail(4).AddToTail(5);
            Console.WriteLine(singlyLinkedList.GetNode(3));

            singlyLinkedList.AddToTail(1).AddToTail(2).AddToTail(3).AddToTail(4).AddToTail(5);
            Console.WriteLine(singlyLinkedList.Search(4));
            Console.WriteLine(singlyLinkedList.Search(10));
        }
    }
}
