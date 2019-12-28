using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace oktayHocaSınavRegexDistinct
{
    class Program
    {
        static void Main(string[] args)
        {

            string str;
            Console.WriteLine("lutfen bir sayı giriniz");
            str = Convert.ToString(Console.ReadLine());
            string desen = @"(\d)";
            Regex rg = new Regex(desen);
            string answer = new String(str.Distinct().ToArray());
            string[] dizi = rg.Split(answer);
            int tane = answer.Length;
            Console.WriteLine("bu sayıda {0} olmak üzere {1} tane birbirinden farklı sayı vardır", answer, tane);

        }
    }
}
