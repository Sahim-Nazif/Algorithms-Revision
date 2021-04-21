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

            myQueue.insert(1);
            myQueue.insert(2);
            myQueue.insert(3);
            myQueue.insert(4);
            myQueue.insert(5);
            
            Console.WriteLine("The front of the queue is " + myQueue.peekFront());
            Console.WriteLine("Removing from queue " + myQueue.remove());
            myQueue.view();
  

        }
    }
}
