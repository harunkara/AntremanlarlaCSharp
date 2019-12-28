using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace splitter
{
    class Program
    {
        static void Main(string[] args)
        {
            string metin;

            char test;

            int i;
            Console.WriteLine("Bir metin giriniz:");
            metin = Console.ReadLine();
            Console.WriteLine("Bölmek istediğiniz karakteri giriniz");
            test = Convert.ToChar(Console.ReadLine());

            for (i = 0; i < metin.Length; i++)
            {
                if (metin[i] != test)
                {
                    Console.Write("{0}", metin[i]);
                }
                else
                {
                    Console.Write("{0}", metin[i] + "\n");

                }



            }
            Console.ReadKey();
        }
    }
}
