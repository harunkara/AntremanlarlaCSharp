using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace karelerToplamiRecursive 
{
    class MyClass
    {
        static void Main()
        {
            int a, b;

            while (true)
            {
                //KARELEER TOPLAMI
                Console.WriteLine("Baslangı sayısı:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Bitis sayısı:");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(rec(a, b));

            }

        }
        static int rec(int a, int b)
        {
            if (a <= b)
                return rec(a + 1, b) + (a * a);
            else
                return 0;
        }

    }
}