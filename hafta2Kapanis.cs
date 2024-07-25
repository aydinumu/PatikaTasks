//Bu çalışmada öğrenilen bütün konulardan örnekler yapılmıştır.
//Metot olan kısımlar özellikle söylenmediği sürece kodu daha da karmaşık ve uzun yapmamak için çağırılmamıştır.

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 - Aşağıdaki çıktıyı yazan bir program.
            Console.WriteLine("Merhaba");
            Console.WriteLine("Nasılsın ?");
            Console.WriteLine("İyiyim");
            Console.WriteLine("Sen nasılsın ?");

            // 2 - Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.
            string textValue = "Metinsel Değişken";
            int numValue = 15;

            Console.WriteLine(textValue);
            Console.WriteLine(numValue);

            // 3 - Rastgele bir sayı üretip , ekrana yazdırınız.
            Random randomNumber1 = new Random();
            Console.WriteLine(randomNumber1.Next(1, 100));

            // 4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.
            Random randomNumber2 = new Random();
            Console.WriteLine(randomNumber2.Next() % 3);

            // 5 - Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.
            Console.Write("Lütfen yaşınızı giriniz : ");
            int userAge = Convert.ToInt32(Console.ReadLine());
            if (userAge >= 18) Console.WriteLine("+");
            else Console.WriteLine("-");

            // 6 - Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
            }

            // 7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.
            Console.Write("İlk değeri giriniz : ");
            string string1 = Console.ReadLine();
            Console.Write("İkinci değeri giriniz : ");
            string string2 = Console.ReadLine();

            //Yerlerini değiştirme işlemi
            string temp = string1;
            string1 = string2;
            string2 = temp;
            Console.WriteLine("Yerlerini değiştirdik ,");
            Console.WriteLine("İlk isim: " + string1);
            Console.WriteLine("İkinci isim: " + string2);

            // 8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.
            void BenDegerDondurmem()
            {
                Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
            }

            // 9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.
            Console.Write("Toplanacak İlk Sayınızı giriniz : ");
            int numTooAdd1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Toplanacak İkinci Sayınızı giriniz : ");
            int numTooAdd2 = Convert.ToInt32(Console.ReadLine());

            int Toplam(int a, int b)
            {
                return a + b;
            }
            Toplam(numTooAdd1, numTooAdd2);

            // 10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.
            string BoolToString(bool boolValue)
            {
                if (boolValue) return "True girdiniz";
                else return "False girdiniz";
            }

            Console.Write("Lütfen 'true' veya 'false' değerini giriniz: ");
            string userInput = Console.ReadLine();
            bool boolValue;
            while (!bool.TryParse(userInput, out boolValue))
            {
                Console.Write("Yanlış girdiniz. Lütfen 'true' veya 'false' değerini giriniz: ");
                userInput = Console.ReadLine();
            }
            string result = BoolToString(boolValue);
            Console.WriteLine("Sonuç: " + result);


          
        }
    }
}
