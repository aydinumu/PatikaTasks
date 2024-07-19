// Bu pratikte bir yardımcı seyehat uygulaması ile kullanıcılarımızın planlayacakları 3 günlük bir tatilde harcayacakları yaklaşık tutarı hesaplamalarına yardımcı oluyoruz.
// Para hesaplarında bilerek float yerine int kullandım, her şeyin tam sayı olacağı varsayımıyla ve sonuçlar ekrana yazdırılırken basit kalması amacıyla.
// Kullanıcının yanlış girdiği yerlerde soru tekrarlanıyor, bazı yerlerde de programdan çıkılacak şekilde tasarladım

using System.Diagnostics.Metrics;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int counter = 0;
            string tripDecision; //Dowhile ile başladığım için önceden tanımlamalıydım.
            Console.WriteLine("HOŞGELDİNİZ !");
            do //Kullanıcı seçeneklerden birini seçmediği sürece 3 defa daha tekrarlıyoruz
            {   
                Console.WriteLine("3 günlük tatil tercihinize uygun yalnızca aşağıdaki 3 Adet seyehat paketimiz bulunmaktadır.");
                Console.WriteLine("     Bodrum   : Kişi başı başlangıç fiyatı 4000TL");
                Console.WriteLine("     Marmaris : Kişi başı Başlangıç fiyatı 3000TL");
                Console.WriteLine("     Çeşme    : Kişi başı Başlangıç fiyatı 5000TL");
                Console.Write("Lütfen gitmek istediğiniz lokasyonu belirtiniz : ");
                tripDecision = Console.ReadLine().ToLower(); //büyük-küçük harf duyarlılığını ortadan kaldırıyoruz
                counter++;
            } while (tripDecision != "bodrum" && tripDecision != "marmaris" && tripDecision != "çeşme" && counter < 3);

                if (counter == 3)
            {   //Can sıkıntısından eklenen bir eklenti
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Yeterince trollediniz :D");
                Console.WriteLine("Program kapatılıyor görüşmek üzere.");
                Environment.Exit(0); //Programı kapatır aşağıdaki kodlara devam etmez
            }

            //Hesap yapabilmek için atama yapıp seçime göre fiyatı belirliyorum
            int pricePerPerson = 0;
            switch (tripDecision)
            {
                case "bodrum":
                    pricePerPerson = 4000;
                    break;
                case "marmaris":
                    pricePerPerson = 3000;
                    break;
                case "çeşme":
                    pricePerPerson = 5000;
                    break;
            }

            Console.Write("Kaç kişilik rezervasyon yaptıracaksınız : ");
            int personCount = Convert.ToInt32(Console.ReadLine());
            if (personCount < 1)
            {
                Console.WriteLine("Bu kişi sayısı için hesap yapmamıza gerek yok zaten ilginiz için teşekkürler. Program kapatılıyor");
                Environment.Exit(0);
            }
                Console.WriteLine($"{tripDecision.ToUpperInvariant()} için {personCount} kişi ara toplam : {pricePerPerson * personCount}");


            Console.WriteLine("------------------------------------------");
            switch (tripDecision) 
            {
                case "bodrum":
                    Console.WriteLine("Bodrum, Türkiye'nin en popüler tatil beldelerinden biridir. Eşsiz koyları, beyaz evleri ve canlı gece hayatıyla ünlüdür. Bodrum Kalesi'ni ziyaret edebilir, antik tiyatroyu görebilir ve Barlar Sokağı'nda eğlenceli bir gece geçirebilirsiniz. Ayrıca, Bodrum’un kristal berraklığındaki denizinde yüzmeyi ve su sporları yapmayı unutmayın.");
                    break;
                case "marmaris":
                    Console.WriteLine("Marmaris, doğal güzellikleri ve tarihi dokusuyla büyüleyici bir tatil beldesidir. Marmaris Kalesi ve çevresindeki tarihi dokuyu keşfedebilir, Marmaris Milli Parkı’nda doğa yürüyüşü yapabi" +
                        "lirsiniz. Ayrıca, Marmaris’in eşsiz koylarında tekne turlarına katılarak denizin tadını çıkarabilir ve muhteşem manzaraların keyfini sürebilirsiniz.");
                    break;
                case "çeşme":
                    Console.WriteLine("Çeşme, uzun plajları ve termal suları ile ünlü bir tatil beldesidir. Alaçatı sokaklarında yürüyüş yapabilir, rüzgar sörfü deneyebilirsiniz. Çeşme Kalesi’ni ziyaret ederek bölgenin tarihini keşfedebilir ve Ilıca Plajı’nda deniz ve güneşin tadını çıkarabilirsiniz. Ayrıca, Çeşme'nin ünlü restoranlarında Ege mutfağının lezzetlerini denemeyi unutmayın.");
                    break;
            }
            Console.WriteLine("------------------------------------------");

            string travelDecision = "0"; //Loop içinde çalıştırıyorum ki farklı cevap verirse tekrar tekrrar sorayım
            int counter2 = 0;
            do {
                Console.WriteLine($"1 - Kara yolu kişi başı gidiş dönüş 1500TL , {personCount} kişi toplam : {personCount * 1500}TL");
                Console.WriteLine($"2 - Hava yolu kişi başı gidiş dönüş 4000TL , {personCount} kişi toplam : {personCount * 4000}TL");
                Console.Write("Hangi yolu tercih edersiniz ? ( 1 / 2 ) : ");
                travelDecision = Console.ReadLine(); 
                if (travelDecision != "1" && travelDecision != "2")
                {
                    if (counter2 == 2)
                    {
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("Yeterince trollediniz :D");
                        Console.WriteLine("Program kapatılıyor görüşmek üzere.");
                        Environment.Exit(0);
                    }

                    Console.WriteLine("Lütfen '1' veya '2' seçeneklerinden birini seçiniz");
                    counter2++;
                    
                }
            } while (travelDecision != "1" && travelDecision != "2");

            int travelPrice = 0;
            switch (travelDecision)
            {
                case "1":
                    travelPrice = 1500;
                    break;
                case "2":
                    travelPrice = 4000;
                    break;
            }

            Console.WriteLine("Yanıtlarınız için teşekkürler,");
            Console.WriteLine($"Toplam ödemeniz gereken ücretiniz : {personCount * (pricePerPerson + travelPrice)}TL");
            Console.WriteLine("İyi eğlenceler dileriz !");

        }

    }
}
