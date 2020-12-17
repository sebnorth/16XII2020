using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekurencja
{
    class Program
    {

        static int f(int n) {

            if (n < 1) return n;
            else if (n == 1) return 1;
            else return 2 * f(n - 1) + 1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj n");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine(f(x));
            Console.WriteLine(f(3)); // 7
            Console.WriteLine(f(f(3))); // 127

            Console.ReadKey();
        }
    }
}
