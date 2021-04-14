using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] topTenMovies2021 = {  "Supernova", "The Dig", "Night of the Kings" };

            LinkedList<string> topMovies = new LinkedList<string>(topTenMovies2021);

            topMovies.AddFirst("The Vigil");
            topMovies.AddLast("17 Blocks");

            foreach(var movie in topMovies)
            {
                Console.WriteLine(movie);
            }

           

            LinkedListNode<string> first = topMovies.First;
            LinkedListNode<string> last = topMovies.Last;

            Console.WriteLine("\nRetrieving the first item in the linked list " + first.Value);
            Console.WriteLine("Retrieving the last item in the linked list " + last.Value);

            //Retrieving the Next Item after the first item and previous item before the last
            Console.WriteLine("\nThe item after the first is " + first.Next.Value);
            Console.WriteLine("The item before the last is " + last.Previous.Value);
            //Items can be added or removed relative to an existing item 
            topMovies.AddAfter(first, "This is Not a Burial");
            topMovies.AddBefore(last, "Land Focus Features");

            foreach(var movie in topMovies)
            {
                Console.WriteLine(movie);
            }

            Console.ReadLine();
        }
    }
}