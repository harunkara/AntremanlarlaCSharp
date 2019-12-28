using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace çokBoyutluDizi
{
    class Dizis
    {
        static void Main(string[] args)
        {
            {
                int i, j;
                i = Convert.ToInt32(Console.ReadLine());
                j = Convert.ToInt32(Console.ReadLine());
                int[,] tablo = new int[i, j];

                for (int k = 0; k < i; k++)
                {
                    for (int f = 0; f < j; f++)
                    {
                        tablo[k, f] = Int32.Parse(Console.ReadLine());
                    }
                }
                for (int k = 0; k < i; k++)
                {
                    for (int f = 0; f < j; f++)
                    {
                        Console.WriteLine("Element({0},{1})={2}", k, f, tablo[k, f]);
                    }
                }


            }
        }
    }
}
