using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList ll = new LinkedList();

            ll.AddAtStart(5);
            ll.AddAtStart(2);
            ll.AddAtStart(1);
            ll.AddAtEnd(7);
            ll.AddAfter(4,2);
            Console.WriteLine(ll.Exists(4));
            if(!ll.Exists(6))
            {
                ll.AddAfter(6, 5);
            }
            ll.DisplayAll();

        }
    }
}
