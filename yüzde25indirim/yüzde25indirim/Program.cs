using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yüzde25indirim
{
    class y25
    {
        static void Main()
        {
            double c, d;
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            c = a + b;
            if (c > 200)
            {
                b = b * 0.25;
                d = c - b;
                Console.WriteLine("indirimli hali:" + d);

            }
            else
                Console.WriteLine("indirimsiz hali:" + c);

        }
    }
}
