 /* Task Description:
    1.Create a list of TV shows where each element will represent a TV show object. 
       The user should be able to input the details of each TV show through the console.
    2. After each TV show is added to the list, ask the user if they want to add another show. 
       If the user decides to stop, proceed to the next steps.
    3. Create a new list from the first list, which only contains comedy shows.
       In this new list, include only the following properties for each show: Show Name, Show Type, and Director.  
    4. Display all elements of this new list, making sure they are sorted first by the show name and then by the director's name.
*/

// NOTE: This project does not include a separate README file.

namespace ConsoleApp1
{
    public class Program
    {
        // Class representing a TV Show
        public class TvShow
        {
            public string Name { get; set; }
            public int ProductionYear { get; set; }
            public string Type { get; set; }
            public int ReleaseYear { get; set; }
            public string Director { get; set; }
            public string Platform { get; set; }

            // Constructor that initializes properties by getting input from the user
            public TvShow()
            {
                Console.Write("Name : ");
                Name = Console.ReadLine();
                Console.Write("Production Year : ");
                ProductionYear = GetValidInt();
                Console.Write("Type : ");
                Type = Console.ReadLine();
                Console.Write("Release Year : ");
                ReleaseYear = GetValidInt();
                Console.Write("Director : ");
                Director = Console.ReadLine();
                Console.Write("Platform : ");
                Platform = Console.ReadLine();

                Console.WriteLine("Succesfully added.\n ---");
            }
        }

        // A simpler class to store only relevant data for the new list (name, type, and director)
        public class TvShowShorter
        {
            public string Name { get; set; }
            public string Type { get; set; }
            public string Director { get; set; }

            // Constructor that accepts specific properties
            public TvShowShorter(string name, string type, string director)
            {
                Name = name;
                Type = type;
                Director = director;
            }
        }

        private static void Main(string[] args)
        {
            // List to store all TV Shows added by the user
            List<TvShow> tvShows = new List<TvShow>();

            // Continuously ask the user if they want to add more shows
            while (true)
            {
                Console.Write("Do you want to add new Tv Show ? ( Y / N ) : ");
                string answer = Console.ReadLine().ToLower();
                if (answer == "y") tvShows.Add(new TvShow());  // Add new show to the list
                else
                {
                    Console.WriteLine("\n\n-------");
                    break; // Break the loop when user doesn't want to add more
                }
            }

            // List to store only comedy TV shows with selected properties (Name, Type, Director)
            List<TvShowShorter> tvShowShorters = new List<TvShowShorter>();
            foreach (var tvShow in tvShows)
            {
                if (tvShow.Type == "Comedy") // Check if the show is of type 'Comedy'
                {
                    var newShow = new TvShowShorter(tvShow.Name, tvShow.Type, tvShow.Director);
                    tvShowShorters.Add(newShow); // Add to the simplified list
                }
            }

            Console.WriteLine("Here is the list of all the comedy shows : ");
            // Sort the new list by Name first and then by Director
            var sortedList = tvShowShorters.OrderBy(x => x.Name).ThenBy(x => x.Director).ToList();
            // Display each comedy show in the sorted order
            foreach (var tvShow in sortedList)
            {
                Console.WriteLine($"Name : {tvShow.Name} , Type : {tvShow.Type} , Director : {tvShow.Director}");
            }
        }

        // Helper method to validate integer input from the user
        public static int GetValidInt()
        {
            if (int.TryParse(Console.ReadLine(), out int result)) return result;
            else
            {
                Console.WriteLine("Invalid input, assigned -1");// Default value if input is invalid
                return -1;
            }
        }
    }
}
