//Bu programda while ve do-while farkı programda incelenmiştir.

using System;
namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tekrar sayısını giriniz : ");
            int limit = Convert.ToInt32(Console.ReadLine());
            int counter = 0;

            if (limit > 0)
            {
                Console.WriteLine($"Kodunuz {limit} kez iki loop ile de çalıştırılacak. ");

            }
            else
            {
                Console.WriteLine($"Kodunuz 1 kez çalıştırılacak ve sadece do-while ile çalışacak. ");
            }
            Console.WriteLine("---------------------");

            while (counter < limit)
            {
                Console.WriteLine("While satırı : Ben bir Patika'lıyım ! " + (counter+1));
                counter++;
            }
            Console.WriteLine("---------------------");
            counter = 0; //Önceki loopta sayı arttığı için tekrar sıfıra çekiyorum
            do
            {
                Console.WriteLine("Do while satırı : Ben bir Patika'lıyım ! " + (counter+1));
                counter++;
            } while (counter < limit);

            //While ile yaptığımda negatif bir değer girersem hiç çalışmıyor
            //Do-while ile yaptığımda negatif bir değer bile girersem en az bir kere çalışıyor.
            //Koşul ilk baştan bile sağlanıyorsa aynı tekrarda çalışıyorlar.
        }

    }
}
