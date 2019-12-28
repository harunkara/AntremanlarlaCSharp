using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme
{
    class Pasas
    {
        struct isci
        {
            public string[] sicil;
            public string[] ad;
            public string[] soyad;
            public string[] tarih;
            public int[] maas;
        };
        static void Main()
        {
            int i = 0, j = 0, t = 0, secim = 0, tut = 0; ;
            string sicil,sa;
            int maks = 0, min = 100000;
            isci p = new isci();
            int k = 0;
            p.ad = new string[10];
            p.soyad = new string[10];
            p.sicil = new string[10];
            p.maas = new int[10];
            p.tarih = new string[10];
            int s = 1;
            while (s == 1)
            {
                Console.WriteLine("lutfen bir secenek secin:");
                Console.WriteLine("1:calisan ekle");
                Console.WriteLine("2:calisan ara");
                Console.WriteLine("3:calisan sil");
                Console.WriteLine("4:en buyuk maas");
                Console.WriteLine("5:en dusuk maas");
                Console.WriteLine("6.ekranı temizle");
                Console.WriteLine("7.programı kapat");
                secim = Convert.ToInt32(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        {
                            Console.WriteLine("sicil:");
                            p.sicil[i] = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("ad:");
                            p.ad[i] = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("soyad:");
                            p.soyad[i] = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("tarih:");
                            p.tarih[i] = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("maas:");
                            p.maas[i] = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            i++;
                            break;
                        }
                    case 2:
                        {

                            Console.WriteLine("arananın sicili gir:");
                            sicil = Convert.ToString(Console.ReadLine());
                            for (j = 0; j < i; j++)
                            {
                                if (sicil == p.sicil[j])
                                {
                                    Console.WriteLine("aranan ad:{0}", p.ad[j].ToString());
                                    Console.WriteLine("aranan soyad:{0}", p.soyad[j].ToString());
                                    Console.WriteLine("aranan sicil:{0}", p.sicil[j].ToString());
                                    Console.WriteLine("aranan maas:{0}", p.maas[j].ToString());
                                    Console.WriteLine("aranan giris tarihi:{0}", p.tarih[j].ToString());
                                    Console.WriteLine();
                                    Console.WriteLine();

                                }

                            }
                            j = 0;
                            break;
                        }
                       
                    case 3:
                        {

                            Console.WriteLine("silinmesini istediğiniz kisinin sicilini giriniz");
                            sa = Convert.ToString(Console.ReadLine());
                            Console.WriteLine();
                           
                            for(k=0;k<i;k++){
                                if (sa == p.sicil[k])
                                {
                                    tut = k;
                                }

                            }
                                    Array.Clear(p.ad, tut, 1);
                                    Array.Clear(p.soyad,tut, 1);
                                    Array.Clear(p.sicil, tut, 1);
                                    Array.Clear(p.maas, tut, 1);
                                    Array.Clear(p.tarih, tut, 1);

                            k = 0;
                          
                            break;
                        }
                    case 4:
                        {
                            for (j = 0; j < i; j++)
                            {
                                if (p.maas[j] > maks)
                                {
                                    maks = p.maas[j];
                                }

                            }

                            Console.WriteLine("en yuksek maas:{0}", maks.ToString());
                            j = 0;
                            break;
                        }
                    case 5:
                        {
                            for (j = 0; j < i; j++)
                            {
                                if (p.maas[j] < min)
                                {
                                    min = p.maas[j];

                                }

                            }
                            Console.WriteLine("En dusuk Maas {0} ", min);
                            j = 0;

                            break;
                        }
                    case 6:
                        {
                            Console.Clear();
                            break;
                        }
                    case 7:
                        {
                            s = 0;
                            break;

                        }
                   
                }
               




            }
        }

    }
}