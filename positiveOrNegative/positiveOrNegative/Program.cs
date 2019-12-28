using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace positiveOrNegative
{
    class PorN
    {
        static void Main()
        {
            double a = Convert.ToDouble(Console.ReadLine());
            if(a<0)
                Console.WriteLine("bu negatif bir sayidir");
            else if(a>0)
                Console.WriteLine("bu pozitif bir sayidir");
            else
                Console.WriteLine("bu sayi kesinlikle 0'dir");

        }
    }
}
