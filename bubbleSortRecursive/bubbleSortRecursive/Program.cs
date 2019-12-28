using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubbleSortRecursive
{
        class Program
        {
            static void Main()
            {
            int r;
            Console.WriteLine("dizi boyutunu giriniz");
            r = Convert.ToInt32(Console.ReadLine());

            double[] array = new double[r];
            for (int y = 0; y < array.Length; y++)
                array[y] = Convert.ToDouble(Console.ReadLine());
            int uzunluk = array.Length;
            array = (Bubble(array, uzunluk));
            foreach (double i in array)
                Console.Write("    {0}", i);
            Console.ReadKey();
        }
        static double[] Bubble(double[] array, int length)
        {
            //recursive sıralama işlemini arrayin elemnları sıralanınca durduruyoruz.

            if (length == 1)
            {
                //arrayi fonksiyona döndür.
                return array;
            }
            //arrayin elemanları ikili ikili karşılaştırılıp büyük olan arayin i+1 indexine
            //küçük olan arrayin i indexine yazılır.
            for (int i = 0; i < length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    double temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                }
            }
            //methodumuz arrayin uzunluğu kadar tekrardan çağırılır.
            return Bubble(array, length - 1);

        }
    }
}
