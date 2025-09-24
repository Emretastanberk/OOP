using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {

            //For Loop
            //int total = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    total += i;

            //    if (total <= 30 && total + (i + 1) > 30)
            //    {
            //        Console.WriteLine($"index: {i}, toplam: {total}");
            //        break;
            //    }
            //}
            //Console.WriteLine("Toplam : " + total);

            //foreach
            //List<int> sayilar = new List<int> { 5, 10, 15, 20, 25 };

            //foreach (int sayi in sayilar)
            //{
            //    Console.WriteLine(sayi);
            //}

            int a = 10;
            int b = 200;
            int c = 110;

            int enBuyuk = a;

            if (b > enBuyuk)
                enBuyuk = b;
            if (c > enBuyuk)
                enBuyuk = c;

            Console.WriteLine("En büyük sayı: " + enBuyuk);
        

    }


    }
}