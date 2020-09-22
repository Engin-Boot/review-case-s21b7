using System;
namespace Sender
{
    public class OutputToConsole
    {
        public static void WordsDisplayOnConsole(string[] words)
        {
            foreach (var t in words)
            {
                Console.WriteLine(t);
            }

            Console.ReadKey();
        }
    }
}
