//Programımızda basit bir bilgi yarışması yapıyoruz.
//Kullanıcıya maksimum 3 soru yönlendirilecek, 2 doğru cevap bekleniyor.
//Cevapları kullanıcı girecek, 2 yanlış olması durumunda 3. soru sorulmayacak
//2 veya 3 doğru cevap ile kullanıcı kazanacak, aksi durumda kaybedecek ve kullanıcıya bildirilecek.
//Fazladan olan Console.WriteLine() ve Console.WriteLine("--") satırları sadece konsol görseli amaçlıdır.

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            //Doğru ve yanlış sayısını tuttuğum değişkenler.
            int correct = 0;

            Console.WriteLine("Merhaba, bilgi yarışmamıza hoş geldiniz, bol şanslar !");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("1. Türkiye'nin başkenti neresidir?");
            Console.WriteLine("a) İstanbul");
            Console.WriteLine("b) Ankara");
            Console.WriteLine("c) İzmir");
            Console.Write("Cevabınız : ");
            //Her cevap için ToLower() metoduyla büyük harf hassasiyetine karşı güvenlik alıyorum.
            string answer1 = Console.ReadLine().ToLower(); 

            //Kullanıcı cevabını kontrol ediyoruz
            //Kullanıcının şık veya uzun cevap ihtimali için || kullanılıyor.
            //Doğru cevap durumunda doğru cevap değişkenim arttırılıyor ve kontrol yapısında kullanılacak
            if (answer1 == "b" || answer1 == "ankara")
            {
                correct++;
                Console.WriteLine("Tebrikler! Doğru cevap! ");
            }
            else
            {
                Console.WriteLine("Malesef yanlış cevap");
            }
            Console.WriteLine();
            Console.WriteLine("2. Güneş sisteminde en büyük gezegen hangisidir?");
            Console.WriteLine("a) Uranüs");
            Console.WriteLine("b) Satürn");
            Console.WriteLine("c) Jüpiter");
            Console.Write("Cevabınız : ");
            string answer2 = Console.ReadLine().ToLower();

            if (answer2 == "c" || answer2 == "jüpiter")
            {
                correct++;
                Console.WriteLine("Tebrikler! Doğru cevap! ");
            }
            else
            {
                Console.WriteLine("Malesef yanlış cevap");
            }
            //Burada correct >=1 değilse kullanıcı iki soruya da yanlış cevap vermiştir ve bu kısım atlanır soru yöneltilmez.
            if (correct >= 1)
            {
                Console.WriteLine();
                Console.WriteLine("3. Dünyanın en uzun nehri hangisidir?");
                Console.WriteLine("a) Nil");
                Console.WriteLine("b) Amazon");
                Console.WriteLine("c) Mississippi");
                Console.Write("Cevabınız : ");
                string answer3 = Console.ReadLine().ToLower();

                if (answer3 == "a" || answer3 == "nil")
                {
                    correct++;
                    Console.WriteLine("Tebrikler! Doğru cevap! ");
                }
                else
                {
                    Console.WriteLine("Malesef yanlış cevap");
                }

            } else
            {
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine($"Maalesef ödül kazanamadınız. Yalnızca {correct} doğrunuz var.");
            }
            //Doğru cevap sayısıyla kazandığını kontrol ediyoruz
            if(correct >1)
            {
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine($"Tebrikler 3 soruda {correct} doğru yanıt vererek 1 Milyon TL'lik büyük ödülü kazandınız!");
                Console.WriteLine("-------------------------------------------------------");
            } else if (correct == 1) //Bu satırın amacı üstteki döngüde yanlış fazlaysa zaten ödül kazanamadığını belirttiği için == kullanılarak tek bir durum değerlendiriliyor.
            {
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine($"Maalesef ödül kazanamadınız. Yalnızca {correct} doğrunuz var.");
            }
        }
    }
}
