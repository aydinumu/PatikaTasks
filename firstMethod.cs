//Aynı uygulama içerisinde 4 farklı metot tanımlanıyor ve hepsi çağırılıyor.

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Geriye değer döndürmeyen Bir Void Metot : ");
            songLyrics();

            Console.WriteLine("-----------------------------");
            Console.WriteLine("2. Geriye Tamsayı Döndüren Bir Metot");
            Console.WriteLine(randomNumbersReminder()); //Şuan bir değişkene atamaya gerek yok sadece çıktı alıyorum

            Console.WriteLine("-----------------------------");
            Console.WriteLine("3. Parametre alan ve Geriye Değer Döndüren Bir Metot");
            Console.WriteLine("Lütfen iki tam sayı giriniz : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( multipication(num1, num2)); //Şuan bir değişkene atamaya gerek yok sadece çıktı alıyorum

            Console.WriteLine("-----------------------------");
            Console.WriteLine("4. Parametre Alan ve Geriye Değer Döndürmeyen Bir Metot");
            Console.Write("Lütfen isminizi giriniz : ");
            string name = Console.ReadLine();
            Console.Write("Lütfen soyisminizi giriniz : ");
            string surname = Console.ReadLine();
            greeting(name, surname);
            Console.WriteLine("-----------------------------");
        }

        //Ekrana şarkı sözü yazdıran metot
        static void songLyrics() 
        {
            Console.WriteLine("And she's buying a stairway to Heaven..");
        }

        //Rastgele sayı üretip 2'ye bölümünden kalanı döndüren metot
        static int randomNumbersReminder()
        {
            Random rnd = new Random();
            int num = rnd.Next();

            return num % 2;
        }

        //İki parametrenin çarpımını veren metot
        static int multipication(int num1, int num2)
        {
            return num1 * num2;
        }

        //iki parametreye hoşçakal diyen fakat return olmayan metot
        static void greeting(string name, string surname)
        {
            Console.WriteLine($"Güle güle {name} {surname}. Görüşmek üzere !");
        }
    }

}
