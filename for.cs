// Bu programda for döngüleriyle alakalı alıştırmalar yapılmıştır.

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.
            for (int i = 0; i < 10; i++) { Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!"); }

            // 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.
            for (int i = 1; i <= 20; i++) { Console.WriteLine(i); }

            // 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
            for (int i = 1; i < 20; i++) { if (i % 2 == 0) Console.WriteLine(i); }

            // 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
            int toplam = 0;
            for (int i = 50; i <= 150; i++)
            {
                toplam += i;
            }
            Console.WriteLine($"50 ile 150 arasındaki sayıların toplamı: {toplam}");

            // 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
            int ciftToplam = 0;
            int tekToplam = 0;
            for (int i = 1; i <= 120; i++)
            {
                if (i % 2 == 0)
                {
                    ciftToplam += i;
                }
                else
                {
                    tekToplam += i;
                }
            }
            Console.WriteLine("1 ile 120 arasındaki çift sayıların toplamı: " + ciftToplam);
            Console.WriteLine("1 ile 120 arasındaki tek sayıların toplamı: " + tekToplam);        
        }
    }
}
