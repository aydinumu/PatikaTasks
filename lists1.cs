// I don't think that I need ReadMe for that :D 
// Just creating a guest list and printing them all in console with foreach as a task

namespace ConsoleApp1
{
    public class Program
    {
        private static void Main(string[] args)
        {
            List<string> guests = new List<string>() { "1 - Bülent Ersoy", "2 - Ajda Pekkan", "3 - Ebru Gündeş", "4 - Hadise", "5 - Hande Yener", "6 - Tarkan", "7 - Funda Arar", "8 - Demet Akalın" };

            foreach (string names in guests)
            {
                Console.WriteLine(names);
            }
        }
    }
}
