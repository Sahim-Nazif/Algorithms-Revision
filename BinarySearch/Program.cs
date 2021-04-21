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


            //if didn't value will return nothing found
            return -1;
        }
       
    }
}
