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
        }
        public static int LinearSerach(int []a, int x)
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
