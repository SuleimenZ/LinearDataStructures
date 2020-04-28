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

            ll.AddAtStart(1233);
            ll.AddAtStart(233);
            ll.AddAtStart(1223);
            ll.AddAtEnd(83);
            ll.RemoveFromEnd();
            ll.RemoveFromStart();
            ll.DisplayAll();
            ll.Clear();
            ll.DisplayAll();

        }
    }
}
