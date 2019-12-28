using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oktayHocaVizeRecursive
{
    class Program
    {
        static void Main()
        {
            int a, b;

            while (true)
            {
                Console.WriteLine("1.sayıyı giriniz");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2.sayıyı giriniz");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(rec(a, b));
            }

        }
        static int rec(int a, int b)
        {


            if (a == 0 || b == 0 && a % 10 != b % 10)
            {
                return 0;
            }
            else if (a % 10 == b % 10)
            {
                return rec(a / 10, b / 10) + 1;
            }

            else
            {
                return rec(a / 10, b / 10) + 0;
            }
        }

    }
}