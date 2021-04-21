using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack(6);

            stack.push("Honeydew");
            stack.push("Run");
            stack.push("The Vault");
            stack.push("Godzilla vs. Kong");
            stack.push("Accomplice");

            while (!stack.isEmpty())
            {
                string movie = stack.pop();
                Console.WriteLine(movie);
            }
            Console.ReadLine();
        }
    }
}
