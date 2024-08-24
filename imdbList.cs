// README
// This program is designed to manage a list of movies with their IMDb scores.
// Users can add an unlimited number of movies, specifying the name and IMDb score for each movie.
// After each entry, the user is asked if they want to add another movie.
// At the end of the program, it will display:
// 1. All movies in the list.
// 2. Movies with IMDb scores between 4 and 9.
// 3. Movies whose names start with 'A' along with their IMDb scores.

// Console has been colored for my own experience

namespace ConsoleApp1
{
    public class Movie
    {
        // Properties for the movie's IMDb points and title
        public double ImdbPoints { get; set; }

        public string Title { get; set; }

        // Constructor that prompts the user to enter the movie's title and IMDb score
        public Movie()
        {
            Console.Write("Enter the Movie Name : ");
            Title = Console.ReadLine();
            Console.Write("Enter the IMDB Point : ");
            ImdbPoints = GetValidDouble();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Movie added to list.\n");
            Console.ResetColor();
        }

        // Method to validate and get a double value from user input
        public static double GetValidDouble()
        {   // Check if the input can be parsed to a double and if it's within the valid range
            if (double.TryParse(Console.ReadLine(), out double result) && (result >= 0 && result <= 10.0))
                return result;
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid imdb point, assigned -1");
                Console.ResetColor();
                return -1; // Return -1 for invalid input without closing program
            }
        }
    }

    public class Program
    {
        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to the IMDB Movie List Program!");
            Console.ResetColor();

            List<Movie> movieList = new List<Movie>(); // List to store movies

            string loopCheck = "y";

            // Loop to add movies until the user decides to stop
            while (loopCheck.ToLower() == "y")
            {
                Movie movie = new Movie();

                movieList.Add(movie);
                Console.Write("Would you like to add more movie to the list ? ( Y/N ) : ");
                loopCheck = Console.ReadLine();
            }

            // Display all movies in the list
            Console.WriteLine("\n----\nAll Movie List\n----");
            for (int i = 0; i < movieList.Count; i++)
            {
                Console.WriteLine(i + 1 + ". Movie Name : " + movieList[i].Title);
                Console.WriteLine(i + 1 + ". Movie Point : " + movieList[i].ImdbPoints + "\n---");
            }

            // Display movies with IMDb scores between 4 and 9
            Console.WriteLine("\n----\nMovies rated between 4 and 9 : ");
            foreach (Movie movie in movieList)
            {
                if (movie.ImdbPoints >= 4 && movie.ImdbPoints <= 9)
                {
                    Console.WriteLine(movie.Title);
                }
            }

            // Display movies whose names start with the letter 'A'
            Console.WriteLine("\n----\nMovies start with letter 'A' : ");

            foreach (Movie movie in movieList)
            {
                if (movie.Title.ToLower()[0] == 'a')
                {
                    Console.WriteLine(movie.Title);
                    Console.WriteLine(movie.ImdbPoints);
                }
            }
            // Exit Program
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Have a nice day !");
            Console.WriteLine("BYEE !!");
            Console.ResetColor();
        }
    }
}
