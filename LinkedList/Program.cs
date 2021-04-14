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
        }
    }
}
