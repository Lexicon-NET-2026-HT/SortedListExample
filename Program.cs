using System.Collections;

namespace SortedListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList sorted = new SortedList();
            sorted["c"] = 3;
            sorted["a"] = 1;
            sorted["b"] = 2;

            foreach (DictionaryEntry entry in sorted)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
    }
}
