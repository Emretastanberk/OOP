using System;
namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            //EkranaYaz();
            //OgrNo(24301071009);
            //IsimSoyisim("Emre", "Taştanberk");
            //Ogrenci(1, "Emre");
            //Ogrenci ogr1 = new Ogrenci();
            //ogr1.numara = 24301071009;
            //ogr1.isim = "Emre";
            //ogr1.soyisim = "Taştanberk";
            //ogr1.not = 95.5;
            //ogr1.BilgileriYazdir();
            //Islem sayiAl = new Islem();
            //sayiAl.sayiAl();

            //Islem topla = new Islem();
            //topla.sayi1 = sayiAl.sayi1;
            //topla.sayi2 = sayiAl.sayi2;
            //Console.WriteLine("Toplama: " + topla.Topla());
            BuyukSayiBul(15, 10, 3);
            


        }

        static int BuyukSayiBul(int sayi1, int sayi2, int sayi3)
        {
            int buyukSayi = sayi1;
            if (sayi2 > buyukSayi)
            {
                buyukSayi = sayi2;
            }
            if (sayi3 > buyukSayi)
            {
                buyukSayi = sayi3;
            }
            return buyukSayi;
        }

            //class Islem
            //{
            //    public int sayi1;
            //    public int sayi2;

            //    public int sayiAl()
            //    {
            //        Console.Write("Birinci sayıyı giriniz: ");
            //        sayi1 = Convert.ToInt32(Console.ReadLine());
            //        Console.Write("İkinci sayıyı giriniz: ");
            //        sayi2 = Convert.ToInt32(Console.ReadLine());
            //        return 0;
            //    }
            //    public int Topla()
            //    {
            //        return sayi1 + sayi2;
            //    }
            //    public int Cikar()
            //    {
            //        return sayi1 - sayi2;
            //    }
            //    public int Carp()
            //    {
            //        return sayi1 * sayi2;
            //    }
            //    public double Bol()
            //    {
            //        return (double)sayi1 / sayi2;
            //    }
            //}
            //class Ogrenci
            //{
            //    public double numara;
            //    public string isim;
            //    public string soyisim;
            //    public double not;

            //    public void BilgileriYazdir()
            //    {
            //        Console.WriteLine("Numara: " + numara);
            //        Console.WriteLine("İsim: " + isim);
            //        Console.WriteLine("Soyisim: " + soyisim);
            //        Console.WriteLine("Not: " + not);
            //    }
            //}

            //static void EkranaYaz()
            //{
            //    Console.WriteLine("mesaj");
            //}
            //static void Ogrenci(int numara, string isim )
            //{
            //    Console.WriteLine(numara +" "+ isim);
            //}
            //static void OgrNo(double no)
            //{
            //    Console.WriteLine(no);
            //}
            //static void IsimSoyisim(string isim, string soyisim)
            //{
            //    Console.WriteLine(isim + " " + soyisim);
            //}
        }
}
