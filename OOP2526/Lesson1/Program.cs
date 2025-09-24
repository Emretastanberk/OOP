using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {


            Islem t = new Islem();
            t.topla();
            t.kalan();

            //int kalan = a % b;
            //if (kalan == 0)
            //    Console.WriteLine("Bu sayılar tam bölünür");
            //else
            //    Console.WriteLine("Bu sayılar tam bölünmez");
        }

        class Islem
        {
            public int topla()
            {
                Console.Write("A sayısını girin: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("B sayısını girin: ");
                int b = int.Parse(Console.ReadLine());
                int toplam = a + b;
                Console.WriteLine("Toplam: " + toplam);
                return toplam;
            }

            public string kalan()
            {
                Console.Write("A sayısını girin: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("B sayısını girin: ");
                int b = int.Parse(Console.ReadLine());
                int kalan_ = a % b;

                if (kalan_ == 0)
                {
                   // Console.WriteLine("Bu sayılar tam bölünür");
                    return "Bu sayılar tam bölünür";
                }
                    
                else
                {
                 //   Console.WriteLine("Bu sayılar tam bölünmez");
                    return "Bu sayılar tam bölünmez";
                }
                    
            }
        }
    }
}