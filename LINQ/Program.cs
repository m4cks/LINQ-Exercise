using System.Linq;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> gameNames = new List<string>() { "Counter-Strike", "League of Legends", "Runescape", "Melee", "osu!", "Super Mario", "Clash Royale" };
            Console.WriteLine("Original List: ");
            
            foreach(string gameName in gameNames)
            {
                Console.WriteLine(gameName);
            }
            
            IEnumerable<string> orderedNames = gameNames.OrderBy(x => x.Length);
            Console.WriteLine("\nOrdered List by Length: ");
           
            foreach(string gameName in orderedNames)
            {
                Console.WriteLine(gameName);
            }
        }
    }
}