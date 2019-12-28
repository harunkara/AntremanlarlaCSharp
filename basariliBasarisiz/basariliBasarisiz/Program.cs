using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basariliBasarisiz
{
    class Ogrenci
    {
        static void Main(string[] args)
        {
            int n,v,f,sayac=0, basarili,basarisiz;
            double ort,ort2=0,so=0;
            n = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                v = Int32.Parse(Console.ReadLine());
                f = Int32.Parse(Console.ReadLine());
                ort = (v * 0.4) + (f * 0.6);
                if (ort > 60)
                    sayac++;
                ort2 += ort;
                so = ort2 / n;
            }
                basarili = sayac;
                basarisiz = n - sayac;
                Console.WriteLine("sinif ortalamasi:{0},basarili:{1},basarisiz:{2}", so, basarili, basarisiz);
                Console.ReadKey();




            }
            

        }
    }

