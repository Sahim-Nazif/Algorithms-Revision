using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    class Program
    {
        /* Linear search is not efficient when searching an element
         * it iterates through all elements to find an element
         * therefore it's taking long time to find an element
         */
        static void Main(string[] args)
        {

            int theValue = 7;
            int[] array = new int[] { 1, 4, 6, 7, 9, 13, 21 };
            Console.WriteLine("The array contains:");
            Array.ForEach(array, x => Console.Write(x + " "));
            Console.Write($"\n\n The result of a Linear search for {theValue} is: ");
            Console.WriteLine(LinearSearch(array, theValue));
            Console.ReadLine();
        }
        public static int LinearSearch(int []a, int x)
        {

            for (int i = 0; i <a.Length; i++)
            {
                if (a[i]==x)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
