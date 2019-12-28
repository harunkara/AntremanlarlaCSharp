using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursiveFibonacci
{
    class Fibonaccii
    {
        static void Main(string[] args)
        {
           
                Console.Write("lutfen bir sayi giriniz:");
                int number = Convert.ToInt32(Console.ReadLine());

                 int[] dizi = new int[number];
                 for (int i = 0; i < number; i++)
                     dizi[i] = Fibonacci(i);
                 foreach (int k in dizi)
                     Console.WriteLine(k);

        }

        public static int Fibonacci(int number)
        {

            if (number < 2)
                return number;

            else
            {
                return Fibonacci(number - 2) + Fibonacci(number - 1);
            }

        }
    }
}