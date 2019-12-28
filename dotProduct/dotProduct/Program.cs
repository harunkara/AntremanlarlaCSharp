using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotProduct
{
    class Program
    {
        static void Main(string[] args)

        {
            int satir = Convert.ToInt32(Console.ReadLine());
            int sutun = Convert.ToInt32(Console.ReadLine());
            double[,] dizi1 = DiziOku(satir, sutun);
            double[,] dizi2 = DiziOku(satir, sutun);
            DiziTopla(dizi1, dizi2);
            Console.ReadKey();
        }
        static double[,] DiziOku(int satir, int sutun)
        {
            Console.WriteLine("Dizi Elemanlarını Giriniz");
            double[,] dizi1 = new double[satir, sutun];
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    Console.Write("[" + i.ToString() + " " + j.ToString() + "] ");
                    dizi1[i, j] = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                }
            }
            return dizi1;
        }
        static void DiziTopla(double[,] dizi1, double[,] dizi2)
        {
            int row = dizi1.GetLength(0);
            int column = dizi1.GetLength(1);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                { Console.Write(" " + Convert.ToString(dizi1[i, j] + dizi2[i, j])); }
            }
        }



    }
}
