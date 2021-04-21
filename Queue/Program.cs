using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    /* a data structure that serves as collection element is called queue */
    class Program
    {
        static void Main(string[] args)
        {

            Queue myQueue = new Queue(5);

            myQueue.Insert(1);
            myQueue.Insert(2);
            myQueue.Insert(3);
            myQueue.Insert(4);
            myQueue.Insert(5);
            
            Console.WriteLine("The front of the queue is " + myQueue.PeekFront());
            Console.WriteLine("Removing from queue " + myQueue.Remove());
            myQueue.View();
  

        }
    }
}
