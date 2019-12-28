using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace diziBubbleSort
{
    class MyClass
    {
        static void Main()
        {
            int a, t;
            Console.WriteLine("dizi boyutunu giriniz!!!");
            a = Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[a];
            for (int y = 0; y < a; y++)
            {
                Console.Write("[{0}]=", y);
                dizi[y] = Convert.ToInt32(Console.ReadLine());
            }
                for (int p = 0; p < dizi.Length - 1; p++)
                {
                for (int i = 0; i < dizi.Length -1; i++)
                {
                    if (dizi[i] > dizi[i + 1])
                    {
                         t = dizi[i + 1];
                         dizi[i + 1] = dizi[i];
                         dizi[i] = t;
                        //alttaki kod aynı işi yapıyor
                      /*t = dizi[i];
                        dizi[i] = dizi[i + 1];
                        dizi[i + 1] = t;*/
                    }
                }
                }
            foreach (var r in dizi)
                Console.Write(r + "   ");
            Console.ReadKey();
        }
    }
}