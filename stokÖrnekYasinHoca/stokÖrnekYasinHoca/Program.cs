using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace stokÖrnekYasinHoca
{
    class Program
    {
        struct Kitap
        {
            public string ISBN;
            public string adi;
            public Yazar yazar;
            public int stok;
            public double fiyat;

            public void Sat(int adet)
            {
                stok -= adet;
            }
            public void Al(int adet)
            {
                stok += adet;
            }
        }
        struct Yazar
        {
            public string adi;
            public string soyadi;
            public string aciklama;
            public Yazar(string ad, string soyad, string aciklama) //yapıcı metod
            {
                adi = ad;
                soyadi = soyad;
                this.aciklama = aciklama;
            }
        }
        static void Main()
        {
            Kitap[] kitaplar = new Kitap[2];
            int idx = 0;
            Kitap kitap = new Kitap();
            kitap.ISBN = "9789753638029";
            kitap.adi = "Kürk Mantolu Madonna";
            kitap.fiyat = 11.5;
            kitap.stok = 40;
            kitap.yazar = new Yazar("Sabahattin", "Ali", "(25 Şubat 1907 - 2Nisan 1948) Türk öykücü, şair, öğretmen, yazar ve gazeteci.");
            kitaplar[idx] = kitap;
            idx++;

            kitap = new Kitap();
            kitap.ISBN = "9789750806629";
            kitap.adi = "Sırça Köşk";
            kitap.fiyat = 9.0;
            kitap.stok = 37;
            kitap.yazar = new Yazar("Sabahattin", "Ali", "(25 Şubat 1907 - 2Nisan 1948) Türk öykücü, şair, öğretmen, yazar ve gazeteci.");
            kitaplar[idx] = kitap;
            Console.WriteLine("Satış öncesi stok: " + kitaplar[0].stok);
            kitaplar[0].Sat(2);
            Console.WriteLine("Satış sonrasi stok: " + kitaplar[0].stok);
        }
    }
}
