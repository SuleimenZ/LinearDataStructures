using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructures
{
    class LinkedList
    {
        public LinkedListNode First { get; set; }
        public LinkedListNode Last { get; set; }
        public int Count { get; set;}

        public LinkedList()
        {
            First = null;
            Last = null;
            Count = 0;
        }

        //This function will insert new element at the start of the list
        public void AddAtStart(int data)
        {
            var NewNode = new LinkedListNode(data, First);
            First = NewNode;
            Count++;
            if(Last == null)
            {
                Last = NewNode;
            }
        }

        //This function will insert new element at the end of the list
        public void AddAtEnd(int data)
        {
            var NewNode = new LinkedListNode(data, null);
            Last.Next = NewNode;
            Last = NewNode;
            Count++;
        }

        //This function will remove element from the start of the list
        public void RemoveFromStart()
        {
            //Checking if there are no elements left
            if(First == null)
            {
                return;
            }

            First = First.Next;
            Count--;
        }

        //This function will remove element from the start of the list
        public void RemoveFromEnd()
        {
            Count--;
            var Node = new LinkedListNode(First.Data, First.Next);
            for (int i = 1; i < Count; i++)
            {
                Node = Node.Next;
            }
            Last = Node;
            Last.Next = null;
        }

        //This function will clear the list
        public void Clear()
        {
            First = null;
            Last = null;
            Count = 0;
        }

        //This function displays all elements of the list
        public void DisplayAll()
        {
            if(First == null)
            {
                Console.WriteLine("There are no elements in the list");
                return;
            }
            var Node = new LinkedListNode(First.Data, First.Next);
            for (int i = 1; i <= Count; i++)
            {
                if(i == Count)
                {
                    Console.Write($"{Node.Data}.");
                    Console.WriteLine();
                    return;
                }
                Console.Write($"{Node.Data}, ");
                Node = Node.Next;
            }
            Console.WriteLine();
        }
    }
}
