using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    /*Binary Search: Finds the position of a target value within
     * a sorted array
     * Continously compares the target value to the middle element
     * of the array and eliminates irrevlant half of array
     */


    class Program
    {
        static void Main(string[] args)
        {
            int theValue = 43;
            int[] array = new int[] { 11, 22, 43, 54, 57, 59, 62, 78 };

            Console.WriteLine("Our array contains: ");
            Array.ForEach(array, x => Console.Write(x + " "));
            Console.Write($"\n\n The result of a binary search for {theValue} is: ");
            Console.WriteLine(binarySearch(array, theValue));
            Console.ReadLine();

        }
        /// <summary>
        /// a=array
        /// x=what we were searching
        /// p= first index
        /// q=midpoint
        /// r=last index
        /// </summary>
   
        public static int binarySearch(int[]a, int x)
        {
            //initialize the variables
            int p= 0;//beginning of the range
            int r = a.Length - 1; //end of the range aka last slot

            //search for the value
            while (p <= r)
            {
                int q = (p + r) / 2;//find the midpoint
                if (x < a[q])

                    r = q - 1;//set r to midpoint. we narrowed to 1st
                              //half of the array in the case x is less
                              //the data in slot q
                else if (x > a[q])
                    p = q + 1;
                else return q;

            }

            //if didn't value will return nothing found
            return -1;
        }
       
    }
}
