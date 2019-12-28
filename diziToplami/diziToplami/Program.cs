using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziToplami
{
    class Program
    {
        static void Main(string[] args)
        {
            int satır, sutun;

            Console.WriteLine(" dizilerin satır sayılarını giriniz");
            satır = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("dizilerin sutun sayılarını giriniz");
            sutun = Convert.ToInt32(Console.ReadLine());
            int[,] dizi1 = diziOku(satır, sutun);
            int[,] dizi2 = diziOku(satır, sutun);
            /*
             BU ŞEKİLDE DE ÇALIŞIR 19,20.SATIR SİLİNİNCE
            int[,] dizi1 = new int[satır,sutun];
            int[,] dizi2 =new int[satır,sutun];
            diziOku(satır, sutun);
            diziOku(satır, sutun);
            */
            dizitopla(dizi1, dizi2, satır, sutun);
            Console.ReadKey();

        }
        static int[,] diziOku(int satır, int sutun)
        {
            int[,] dizi = new int[satır, sutun];
            for (int y = 0; y < satır; y++)
                for (int z = 0; z < sutun; z++)
                {
                    Console.WriteLine("[{0},{1}]", y, z);
                    dizi[y, z] = Convert.ToInt32(Console.ReadLine());
                }
            return dizi;

        }
        static void dizitopla(int[,] dizi1, int[,] dizi2, int satır, int sutun)
        {
            int[,] sonuc = new int[satır, sutun];
            for (int y = 0; y < satır; y++)
                for (int z = 0; z < sutun; z++)
                    sonuc[y, z] = dizi1[y, z] + dizi2[y, z];
            /* for (int y = 0; y < satır; y++)
                 for (int z = 0; z < sutun; z++)
                 {
                     Console.WriteLine("sonuc[{0},{1}]={2}", y, z, sonuc[y, z]);

                 }
                 */
        
                foreach (int v in sonuc)
                    Console.WriteLine( v);
          
        }
    }
}
