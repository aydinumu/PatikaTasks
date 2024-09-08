// 1. Create a list of Singer objects from the given data.
// 2. Find and print the names of singers whose name starts with 'S'.
// 3. Find and print the names of singers with album sales over 10 million.
// 4. Find and print the names of singers who released before 2000 and make pop music, sorted by release year and then by name.
// 5. Find and print the name of the singer with the most album sales.
// 6. Find and print the names of the newest and oldest singers.
//
// NOTE: This project does not include a separate README file.

namespace ConsoleApp1
{
    public class Program
    {
        public class Singer
        {
            public string Name { get; set; }
            public string MusicType { get; set; }
            public int ReleaseYear { get; set; }
            public int AlbumSales { get; set; }
        }

        public static void printSpace()
        {
            Console.WriteLine("\n----------\n");
        }

        private static void Main(string[] args)
        {
            // List of Singer objects
            List<Singer> singers = new List<Singer>
            {
                 new Singer { Name = "Ajda Pekkan", MusicType = "Pop", ReleaseYear = 1968, AlbumSales = 20 },
                 new Singer { Name = "Sezen Aksu", MusicType = "Turkish Folk Music / Pop", ReleaseYear = 1971, AlbumSales = 10 },
                 new Singer { Name = "Funda Arar", MusicType = "Pop", ReleaseYear = 1999, AlbumSales = 3 },
                 new Singer { Name = "Sertab Erener", MusicType = "Pop", ReleaseYear = 1994, AlbumSales = 5 },
                 new Singer { Name = "Sıla", MusicType = "Pop", ReleaseYear = 2009, AlbumSales = 3 },
                 new Singer { Name = "Serdar Ortaç", MusicType = "Pop", ReleaseYear = 1994, AlbumSales = 10 },
                 new Singer { Name = "Tarkan", MusicType = "Pop", ReleaseYear = 1992, AlbumSales = 40 },
                 new Singer { Name = "Hande Yener", MusicType = "Pop", ReleaseYear = 1999, AlbumSales = 7 },
                 new Singer { Name = "Hadise", MusicType = "Pop", ReleaseYear = 2005, AlbumSales = 5 },
                 new Singer { Name = "Gülben Ergen", MusicType = "Turkish Folk Music / Pop", ReleaseYear = 1997, AlbumSales = 10 },
                 new Singer { Name = "Neşet Ertaş", MusicType = "Turkish Folk Music / Turkish Classical Music", ReleaseYear = 1960, AlbumSales = 2 }
            };

            // Singers whose name starts with 'S'
            Console.WriteLine("Singers whose name starts with 'S' : ");
            var singersStartingWithS = singers.Where(name => name.Name.StartsWith("S")).ToList();
            foreach (var singer in singersStartingWithS) { Console.WriteLine(" - " + singer.Name); }
            printSpace();

            // Singers with album sales over 10 million
            Console.WriteLine("Singers with album sales of over 10 million : ");
            var singersSales10Million = singers.Where(name => name.AlbumSales >= 10).ToList();
            foreach (var singer in singersSales10Million) { Console.WriteLine(" - " + singer.Name); }
            printSpace();

            // Names of singers who released before 2000 and make pop music, sorted by release year and then by name.
            Console.WriteLine("Singers who released before 2000 and their representetive years : ");
            var PopSingersBefore2000 = singers.Where(name => name.ReleaseYear < 2000 && name.MusicType == "Pop").OrderBy(name => name.ReleaseYear).ThenBy(name => name.Name).ToList();
            foreach (var singer in PopSingersBefore2000) { Console.WriteLine(" - " + singer.Name + " - " + singer.ReleaseYear); }
            printSpace();

            // Finding the name of the singer with the most album sales
            var singerWithMostAlbumSales = singers.Aggregate((max, current) => current.AlbumSales > max.AlbumSales ? current : max);
            Console.WriteLine($"Singer with the most album sales : {singerWithMostAlbumSales.Name} sold more than {singerWithMostAlbumSales.AlbumSales} million albums.");
            printSpace();

            // Newest and oldest singer
            var newestSinger = singers.OrderByDescending(s => s.ReleaseYear).First();
            var oldestSinger = singers.OrderBy(s => s.ReleaseYear).First();
            Console.WriteLine($"Newest singer: {newestSinger.Name} ({newestSinger.ReleaseYear})");
            Console.WriteLine($"Oldest singer: {oldestSinger.Name} ({oldestSinger.ReleaseYear})");
            printSpace();
        }
    }
}
