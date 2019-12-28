using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesapMakinesi
{
    class hMakinesi
    {
        static void Main()
        {
            double sonuc=0;
            Console.WriteLine("bir sayi girin");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("baska bir sayi girin");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("toplama:+,cikarma:-,carpma:*,bolme:/ kullaniniz");
            char islem = Convert.ToChar(Console.ReadLine());
            switch (islem)
            {
                case '-':
                    sonuc = a - b;
                    break;
                case '+':
                    sonuc = a + b;
                    break;
                case '/':
                    sonuc = a / b;
                    break;
                case '*':
                    sonuc = a * b;
                    break;

            }

            Console.WriteLine("sonuc="+sonuc);


        }
    }
}
