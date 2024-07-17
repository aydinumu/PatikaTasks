using System.Diagnostics;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Basit bir manav uygulaması
            //Kullanıcıya ürünler sunuluyor ve istediği ürün soruluyor, seçilen ürünün parası ekrana yazdırılıyor.

            Console.WriteLine("Umut manavına hoş geldiniz ! ");
            Console.WriteLine("Elma = 2 TL");
            Console.WriteLine("Armut = 3 TL");
            Console.WriteLine("Çilek = 2 TL");
            Console.WriteLine("Muz = 3 TL");
            Console.WriteLine("Diğer = 4 TL");
            Console.WriteLine(); // Çıktıda okunabilirliği kolaylaştırmak için

            Console.Write("Hangi meyveden istersiniz ? (Elma / Armut / Çilek / Muz / Diğer : ");
            string decision = Console.ReadLine();

            Console.WriteLine("---------------------");
            Console.WriteLine();

            switch (decision.ToLower()) //Kullanıcı girdisinin büyük harf küçük harf duyarlılığı gideriliyor
            {
                case "elma":
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı : 2 TL");
                    break;
                case "armut":
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı : 3 TL");
                    break;
                case "çilek":
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı : 2 TL");
                    break;
                case "muz":
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı : 3 TL");
                    break;
                case "diğer":
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı : 4 TL");
                    break;
                default: //Kullanıcının seçenekler dışında bir şey yazması durumunda
                    Console.WriteLine("Manavımızda bu ürün ne yazık ki bulunmamaktadır.");
                    break;

                    //Hızlı çalışması ve okunabilirliği açısından switch case yapısı daha mantıklı, çünkü tek koşul sorgulanıyor.
            }
        }
    }
}
