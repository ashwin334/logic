using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;

            int b = a++;  // b=10  a=11

            int c = ++b + ++a; // 11 + 12    

            Console.WriteLine(a); //
            Console.WriteLine(b); //
            Console.WriteLine(c); //


        }
    }
}
