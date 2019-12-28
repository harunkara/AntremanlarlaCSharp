using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace structDizideBilgi
{
    class Program
    {
        struct personel
        {
            public string ad;
            public string soyad;
            public double maas;
        }
        static void Main()
        {
            int t;
            //int y = 0;



            //personel[] personeller_dizisi = new personel[9999];
            List<personel> personeller_dizisi = new List<personel>();


            personel person = new personel();
            while (true)
            {
                Console.WriteLine("lutfen işlem seçiniz:");
                Console.WriteLine("1->kişi ekle");
                Console.WriteLine("2->kişi bilgisi görüntüle");
                t = Convert.ToInt32(Console.ReadLine());
                switch (t)
                {
                    case 1:
                        {
                            Console.WriteLine("kaydedilecek kişinin adı:");
                            person.ad = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("kaydedilecek kişinin soyadı:");
                            person.soyad = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("kaydedilecek kişinin maası:");
                            person.maas = Convert.ToInt32(Console.ReadLine());
                            personeller_dizisi.Add(person);
                            //personeller_dizisi[y] = person;
                            //y++;
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("aranan kişinin ismini girin:");
                            string f;
                            f = Convert.ToString(Console.ReadLine());

                            for (int e = 0;/*e< personeller_dizisi.Length; */e < personeller_dizisi.Count; e++)
                            {
                                if (f == personeller_dizisi[e].ad)
                                {
                                    Console.WriteLine("{0},{1},{2}", personeller_dizisi[e].ad, personeller_dizisi[e].soyad, personeller_dizisi[e].maas.ToString());
                                }     
                            }
                            break;
                      
                        }




                }
            }


        }

    }
}

