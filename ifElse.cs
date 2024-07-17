namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {    
            //Programda kullanıcıdan bir sayı değeri alınarak sayının 0'dan büyük veya küçük olma ve çift veya tek olma durumu çıktı olarak verilmektedir.
            //Programda hatasız bir şekilde tam sayı girildiği varsayılmıştır.
            
            Console.Write("Lütfen bir sayı giriniz : ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 0) { Console.WriteLine("Sayı 0'a eşittir"); }
            else if (num > 0) { Console.WriteLine("Sayı 0'dan büyüktür"); }
            else { Console.WriteLine("Sayı 0'dan küçüktür"); }

            Console.WriteLine( num % 2 == 0 ? "Sayı çift sayıdır" : "Sayı tek sayıdır");
        }
    }
}
