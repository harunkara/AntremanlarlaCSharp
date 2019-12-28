using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noktaUzaklık
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            Console.WriteLine(" x,y değerleri girilecek nokta sayısını yazınız:");
            i = Convert.ToInt32(Console.ReadLine());
            double[] dizix = new double[i];
            double[] diziy = new double[i];
            double[] ssdizi = new double[i];
            for (int k = 0; k < i; k++)
            {
                Console.WriteLine("x[{0}]değerini giriniz:", k);
                dizix[k] = Convert.ToDouble(Console.ReadLine());

            }
            for (int j = 0; j < i; j++)
            {
                Console.WriteLine("y[{0}] değerini giriniz:", j);
                diziy[j] = Convert.ToDouble(Console.ReadLine());
            }
            ssdizi = Sonuc(dizix, diziy, i);
            Array.Sort(ssdizi);
            foreach (double r in ssdizi)
                Console.WriteLine(r);
            Console.ReadKey();

        }
        static double[] Sonuc(double[] x, double[] y, int i)
        {
            double[] sdizi = new double[i];
            double carpim;
            for (int t = 0; t < i; t++)
            {
                carpim = (x[t] * x[t]) - (y[t] * y[t]);
                if (carpim < 0)
                    carpim = (-1 * carpim);
                else
                    carpim = (1 * carpim);

                sdizi[t] = Math.Sqrt(carpim);

            }
            return sdizi;

        }


    }
}