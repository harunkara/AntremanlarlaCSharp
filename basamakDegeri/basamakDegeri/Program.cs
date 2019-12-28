using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basamakDegeri
{
    class Basamak
    {
        static void Main(string[] args)
        {
           int n= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Basamaks(n).ToString());
        }
        static int Basamaks(int n)
        {if (n / 10 == 0)
                return 1;
            else
                return (Basamaks(n / 10) + 1);

        }
    }
}
