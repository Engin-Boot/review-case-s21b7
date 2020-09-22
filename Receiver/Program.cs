using System;
using System.Collections.Generic;

namespace Receiver
{
    class Program
    {
        private static readonly List<string> InputValues = new List<string>();
        static void Main()
        {
            string s;
            while ((s = Console.ReadLine()) != null)
            {
                //Console.WriteLine(s);
                InputValues.Add(s);
            }
            
            string[] words = InputValues.ToArray();

            WriteToCsvFile writeCsvFile=new WriteToCsvFile();
            WordAndWordCount wordCount=new WordAndWordCount();
            var wordCount2 = wordCount.WordsAndFrequency(words) ?? throw new Exception();
            var status = writeCsvFile.RedirectToCsvFile(wordCount2);
            Console.WriteLine(status);
            //Console.ReadKey();
            
        }
    }
}
