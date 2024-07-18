// Bu programda while döngüleriyle alakalı basit alıştırmalar yapılmıştır.

using System;
namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.
            int num1 = 0;
            while (num1 < 10)
            {
                Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
                num1++;
            }

            // 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.
            int num2 = 1;
            while (num2 <= 20)
            {
                Console.WriteLine(num2);
                num2++;
            }

            // 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
            int num3 = 2;
            while (num3 <= 20)
            {
                if (num3 % 2 == 0) { Console.WriteLine(num3); }
                num3++;
            }

            // 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
            int toplam = 0, num4 = 50;
            while (num4 <= 150) { toplam += num4; num4++; }
            Console.WriteLine("toplam : " + toplam);

            //1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
            int ciftToplam = 0, tekToplam = 0, num5 = 1;
            while (num5 <= 120)
            {
                if (num5 % 2 == 0)
                {
                    ciftToplam += num5;
                    num5++;
                }
                else
                {
                    tekToplam += num5;
                    num5++;
                }
            }

            Console.WriteLine("Çift: " + ciftToplam + ", Tek: " + tekToplam);

        }
    }
}
