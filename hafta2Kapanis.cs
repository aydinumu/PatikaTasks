//Bu çalışmada öğrenilen bütün konulardan örnekler yapılmıştır.
//Bazı kısımlarda konsolda kullanıcıya ne yapılacağını açıkça belirtmediğimin farkındayım.

using System;

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
            string textValue = "patika plus";
            int numValue = 15;
            Console.WriteLine(textValue);
            Console.WriteLine(numValue);

            // 3 - Rastgele bir sayı üretip , ekrana yazdırınız.
            Random randomNumber1 = new Random();
            int rndm1 = randomNumber1.Next(1, 100);
            Console.WriteLine(rndm1);

            // 4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.
            Random randomNumber2 = new Random();
            int rndm2 = randomNumber2.Next();
            Console.WriteLine($"Rastgele sayı : {rndm2} ve 3'e bölümünden kalan : {rndm2 % 3}");

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
            BenDegerDondurmem(); //void olduğu ve içeride cw olduğu için ekranda görebileceğiz

            // 9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.
            int TwoNumberAddition()
            {
                Console.Write("Birinci sayıyı giriniz: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("İkinci sayıyı giriniz: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                return num1 + num2;
            }
            Console.WriteLine(TwoNumberAddition());

            // 10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.
            string BoolToString()
            {
                Console.Write("Lütfen 'true' veya 'false' değerini giriniz: ");
                string userInput = Console.ReadLine();
                bool boolValue;
                while (!bool.TryParse(userInput, out boolValue))
                {
                    Console.Write("Yanlış girdiniz. Lütfen 'true' veya 'false' değerini giriniz: ");
                    userInput = Console.ReadLine();
                }
                if (boolValue) return "True girdiniz";
                else return "False girdiniz";
            }
            Console.WriteLine(BoolToString());

            //  11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.
            int GetOldestAge()
            {
                Console.Write("1. kişinin yaşını giriniz : ");
                int age1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2. kişinin yaşını giriniz : ");
                int age2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("3. kişinin yaşını giriniz : ");
                int age3 = Convert.ToInt32(Console.ReadLine());
                return Math.Max(age1, Math.Max(age2, age3));
            }
            Console.WriteLine("En yaşlı insan : " + GetOldestAge());

            // 12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.           
            int FindBiggestNumber()
            {
                int maxNumber = int.MinValue;
                bool hasNumber = false; // Kullanıcı sayı girip girmediğini kontrol etmek için
                Console.WriteLine("Lütfen sayıları girdikçe 'enter' basınız, çıkmak için 'q' yazıp enter basınız.");
                while (true)
                {
                    string input = Console.ReadLine();
                    if (input.ToLower() == "q") break;
                    if (int.TryParse(input, out int numberOut))
                    {
                        hasNumber = true;
                        if (numberOut > maxNumber) maxNumber = numberOut;
                    }
                    else Console.WriteLine("Geçerli bir sayı giriniz veya çıkmak için 'q' yazınız.");
                }

                if (hasNumber) return maxNumber;
                else return int.MinValue; // Hiç sayı girilmediğinde dönecek değer
            }
            //Hepsini metot içine nasıl koyabileceğimi bulamadım. Yardım edebilirsiniz :) 
            int biggestNumber = FindBiggestNumber();
            if (biggestNumber == int.MinValue) Console.WriteLine("Hiç sayı girilmedi.");
            else Console.WriteLine("En büyük sayı: " + biggestNumber);

            // 13- Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.
            void SwapNames()
            {
                Console.WriteLine("İsimlerin yerleri değiştirilecektir,");
                Console.Write("İlk ismi giriniz : ");
                string name1 = Console.ReadLine();
                Console.Write("İkinci ismi giriniz : ");
                string name2 = Console.ReadLine();

                string tempName = name1;
                name1 = name2;
                name2 = tempName;
                Console.WriteLine($"Yerler değişti, ilk isim : {name1} , ikinci isim : {name2} oldu.");
            }
            SwapNames();

            // 14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.
            bool IsOdd()
            {
                Console.Write("Bir sayı girin: ");
                int number = Convert.ToInt32(Console.ReadLine());
                return number % 2 == 0;
            }
            Console.WriteLine(IsOdd());

            // 15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.
            double CalculateDistance()
            {
                Console.Write("Saatte km hızla gittiniz : ");
                int speed = Convert.ToInt32(Console.ReadLine());
                Console.Write("Kaç dakikada gittiniz : ");
                int time = Convert.ToInt32(Console.ReadLine());

                //Saatteki hızını aldığımız için 60'a da bölüyoruz
                double distance = speed * time / 60.0;
                return distance;
            }
            Console.WriteLine("Gidilen yol : " + CalculateDistance() + "km'dir.");

            // 16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.
            double CalculateAreaOfCircle()
            {
                Console.Write("Dairenin Yarıçapı giriniz : ");
                double radius = Convert.ToDouble(Console.ReadLine());
                // A = πr2
                return Math.PI * Math.Pow(radius, 2);
            }
            Console.WriteLine("Dairenin alanı : " + CalculateAreaOfCircle());

            // 17 - "Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.
            string patikaOzluSoz = "Zaman bir GeRi SayIm";
            Console.WriteLine("Hepsi Büyük Harf : " + patikaOzluSoz.ToUpper());
            Console.WriteLine("Hepsi Büyük Harf : " + patikaOzluSoz.ToLower());

            // 18 - "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.
            string firstSentence = "    Selamlar   ";
            firstSentence = firstSentence.Trim();
            Console.WriteLine("Bakalım boşluk var mı : " + firstSentence + " var mı ? Yok gibi.");
        }

    }
}

