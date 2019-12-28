using System;

namespace randomSayılarDiziler
{
    class Program
    {
        static void Main(string[] args)

        {

            int a, s = 0, p = 0, o = 0;
            Console.WriteLine("random sayı miktarını gir");
            a = Convert.ToInt32(Console.ReadLine());
            int[] dizi1;
            int[] dizi2;
            int[] dizi3;
            int[] dizilk = new int[a];
            int pi = 0, ni = 0, on = 0;
            Random rnd = new Random();
            for (int i = 0; i < a; i++)
            {
                dizilk[i] = Convert.ToInt32(rnd.Next(0,100));

                if (dizilk[i] < 0)
                {
                    s++;
                }
                else if (dizilk[i] > 0)
                {
                    p++;
                }
                else
                {
                    o++;
                }

            }

            dizi1 = new int[s];
            dizi2 = new int[p];
            dizi3 = new int[o];

            for (int k = 0; k < a; k++)
            {
                if (dizilk[k] < 0)
                {
                    dizi1[pi] = dizilk[k];
                    pi++;
                }
                else if (dizilk[k] > 0)
                {
                    dizi2[ni] = dizilk[k];
                    ni++;
                }
                else
                {
                    dizi3[on] = dizilk[k];
                    on++;
                }

            }


            foreach (int g in dizi1)
            {
                Console.WriteLine("negatif sayılar:{0}", g);
            }
            Console.WriteLine();
            foreach (int h in dizi2)
            {
                Console.WriteLine("pozitif sayılar:{0}", h);
            }
            Console.WriteLine();

            foreach (int j in dizi3)
            {
                Console.WriteLine("0'lar:{0}", j);
            }
            Console.WriteLine();

        }
    }
}

