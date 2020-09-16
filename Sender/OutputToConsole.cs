using System;
namespace Sender
{
    public class OutputToConsole
    {
        public static void WordsDisplayOnConsole(string[] words)
        {
            for (int i = 0; i <words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
            Console.ReadKey();
        }
    }
}
