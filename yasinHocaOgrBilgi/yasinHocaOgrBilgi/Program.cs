using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace yasinHocaOgrBilgi
{

    struct Ogrenci
    {
        public string isim, soyisim, no;
        public double vize, final;
        private double ortalama;
        public double OrtalamaHesapla()
        {
            return (vize * 40 / 100) + (final * 60 / 100);
        }
    }
    struct Ders
    {
        public string dersKodu;
        public Ogrenci[] Ogrenciler;
        public Ders(string kod, int kontenjan)
        {
            dersKodu = kod;
            Ogrenciler = new Ogrenci[kontenjan];
        }
    }
    class Program
    {

        static int DersAra(Ders[] Dersler, string dersKodu)
        {
            for (int i = 0; i < Dersler.GetLength(0); i++)
            {
                Ders d = Dersler[i];
                if (d.dersKodu == dersKodu)
                {
                    return i;
                }
            }
            return -1;
        }
        static Ders[] DersSil(Ders[] Dersler, string dersKodu)
        {
            int iders = DersAra(Dersler, dersKodu);
            if (iders != -1)
            {
                for (int i = iders; i < Dersler.GetLength(0) - 1; i++)
                {
                    Dersler[i] = Dersler[i + 1];
                    Dersler[i + 1].dersKodu = null;
                    Dersler[i + 1].Ogrenciler = null;
                }
            }
            else
            {
                Console.WriteLine("Ders bulunamadı");
            }
            return Dersler;
        }
        static int OgrenciAra(Ogrenci[] Ogrenciler, string ogrNo)
        {
            for (int i = 0; i < Ogrenciler.GetLength(0); i++)
            {
                Ogrenci d = Ogrenciler[i];
                if (d.no == ogrNo)
                {
                    return i;
                }
            }
            return -1;
        }
        static Ogrenci[] OgrenciSil(Ogrenci[] Ogrenciler, string ogrNo)
        {
            int iogr = OgrenciAra(Ogrenciler, ogrNo);
            if (iogr != -1)
            {
                for (int i = iogr; i < Ogrenciler.GetLength(0) - 1; i++)
                {
                    Ogrenciler[i] = Ogrenciler[i + 1];
                    Ogrenciler[i + 1].no = null;
                    Ogrenciler[i + 1].isim = null;
                    Ogrenciler[i + 1].soyisim = null;
                    Ogrenciler[i + 1].vize = 0;
                    Ogrenciler[i + 1].final = 0;
                }
            }
            else
            {
                Console.WriteLine("Ders bulunamadı");
            }
            return Ogrenciler;
        }
        static void Main()
        {
            Ders[] Dersler = new Ders[10];
            int idx = 0;
            bool donAnaMenu = true;
            while (donAnaMenu)
            {
                Console.Clear();
                Console.WriteLine("Personel Bilgi Sistemi\nYapmak istediğiniz işlemiseçiniz.");

                Console.WriteLine("1->Ders ekle");
                Console.WriteLine("2->Ders sil");
                Console.WriteLine("3->Dersleri listele");
                Console.WriteLine("4->Var olan dersi güncelle");
                Console.WriteLine("5->Uygulama sonlandır");
                int secim = Convert.ToInt32(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        {
                            Console.Write("Dersin Kodu:");
                            string kod = Console.ReadLine();
                            Console.Write("Kontenjan:");
                            int kontenjan = Convert.ToInt32(Console.ReadLine());
                            Dersler[idx] = new Ders(kod, kontenjan);
                            idx++;
                            Console.Write("Ders eklendi.");
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Dersin Kodu:");
                            string kod = Console.ReadLine();
                            Dersler = DersSil(Dersler, kod);
                            idx--;
                            Console.Write("Ders silindi.");
                            break;
                        }
                    case 3:
                        {
                            foreach (Ders d in Dersler)
                            {
                                if (d.dersKodu != null)
                                {
                                    Console.WriteLine("BM" + d.dersKodu + " Kontenjan:" +
                                   d.Ogrenciler.GetLength(0));
                                    foreach (Ogrenci o in d.Ogrenciler)
                                    {
                                        if (o.no != null)
                                        {
                                            Console.Write(o.no + ": " + o.isim + " " +
                                           o.soyisim + "\t" + o.vize.ToString() + "\t" + o.final.ToString() + "\n");
                                        }
                                    }
                                }
                            }
                            Console.WriteLine("Devam etmek için bir tuşa basın");
                            Console.ReadKey();
                            break;
                        }
                    case 5:
                        {
                            donAnaMenu = false;
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Dersin kodu:");
                            string kod = Console.ReadLine();
                            Console.WriteLine("BM" + kod.ToString() + " için yapmakistediğiniz işlemi seçiniz.");

                            bool don = true;
                            int idxDers = DersAra(Dersler, kod);
                            int idOgrenci = 0;
                            while (don)
                            {
                                Console.WriteLine("1->Ögrenci ekle");
                                Console.WriteLine("2->Ögrenci sil");
                                Console.WriteLine("3->Öğrencileri listele");
                                Console.WriteLine("4->Ana menüye dön");
                                int secimAltMenu = Convert.ToInt32(Console.ReadLine());
                                switch (secimAltMenu)
                                {
                                    case 1:
                                        {
                                            Ogrenci ogrenci = new Ogrenci();
                                            Console.Write("Ögrenci No: ");
                                            ogrenci.no = Console.ReadLine();
                                            Console.Write("Ögrenci İsim: ");
                                            ogrenci.isim = Console.ReadLine();
                                            Console.Write("Ögrenci Soyisim: ");
                                            ogrenci.soyisim = Console.ReadLine();
                                            Console.Write("Vize Notu: ");
                                            ogrenci.vize =
                                           Convert.ToDouble(Console.ReadLine());
                                            Console.Write("Final Notu: ");
                                            ogrenci.final =
                                           Convert.ToDouble(Console.ReadLine());
                                            Dersler[idxDers].Ogrenciler[idOgrenci] =
                                           ogrenci;
                                            idOgrenci++;
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.Write("Öğrenci Numarası");
                                            string no = Console.ReadLine();
                                            Dersler[idxDers].Ogrenciler =
                                           OgrenciSil(Dersler[idxDers].Ogrenciler, no);
                                            idOgrenci--;
                                            Console.Write("Ogrenci silindi.");
                                            break;
                                        }
                                    case 3:
                                        {
                                            foreach (Ogrenci o in
                                           Dersler[idxDers].Ogrenciler)
                                            {
                                                if (o.no != null)
                                                {
                                                    Console.Write(o.no + ": " + o.isim + " " + o.soyisim + "\t" + o.vize.ToString() + "\t" + o.final.ToString() + "\n");
                                                }
                                            }
                                            break;
                                        }
                                    case 4:
                                        {
                                            don = false;
                                            break;
                                        }
                                    default:
                                        break;

                                }

                            }
                            break
                            ;

                        }
                    default
               :
                        break
                       ;

                }

            }

        }

    }
}
