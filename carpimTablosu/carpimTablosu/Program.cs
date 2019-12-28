
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carpimTablosu
{
    class CarpimTablo
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int J = 1; J <= 10; J++) 
                {
                    int sonuc = 1;
                    sonuc = i * J;
                    Console.WriteLine("{0}*{1}={2}", i, J, sonuc);
                }
                Console.WriteLine("----------------------------------");
            }
            Console.ReadKey();
        }
    }
}