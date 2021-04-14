using Algorithms_Revision.Singly_Linked_List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Revision
{
    class Program
    {
        static void Main(string[] args)
        {

            SinglyLinkedList list = new SinglyLinkedList();
            list.insertFirst(1);
            list.insertFirst(2);
            list.insertFirst(3);
            list.insertFirst(4);
            list.insertFirst(5);
            list.inserLast(8);
        
            list.displayList();
            list.deleteFirst();
            list.displayList();
            Console.ReadLine();


        }
    }
}
