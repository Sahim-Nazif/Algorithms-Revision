using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack
    {
        private int maxSize;
        private string[] stackArray;
        private int top;

        public Stack(int size)
        {
            maxSize = size;

            stackArray = new string[maxSize];
        }
    }
}
