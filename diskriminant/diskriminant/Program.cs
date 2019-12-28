using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diskriminant
{
    class Disk
    {
        static void Main(string[] args)
        {
            double x1, x2;
            Console.WriteLine("lutfen ikinci dereceden olan(a*(x*x)+b*x+c) denklemin degerlerini giriniz");
            Console.WriteLine("a degerini giriniz:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b degerini giriniz:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("c degerini giriniz:");
            int c = Convert.ToInt32(Console.ReadLine());
            double dis;
            dis = (Math.Pow(b, 2)) - (4 * a * c);
            if (dis >= 0)
            {
                x1 = (-b - (Math.Sqrt(dis))) / (2 * a);
                x2 = (-b + (Math.Sqrt(dis))) / (2 * a);
                Console.WriteLine("kok1:{0},kok2:{1}",x1,x2);

            }
            else
                Console.WriteLine("sayının koku yoktur");

            Console.ReadKey();
        }

    }
}
