using System;
using System.Collections.Generic;

namespace Receiver
{
    class Program
    {
        static List<string> inputvalues = new List<string>();
        static void Main()
        {
            string s;
            string status;
            while ((s = Console.ReadLine()) != null)
            {
                //Console.WriteLine(s);
                inputvalues.Add(s);
            }
            
            string[] words = inputvalues.ToArray();

            WriteToCsvFile wtcf=new WriteToCsvFile();
            WordAndWordCount wawc=new WordAndWordCount();
            Dictionary<String, int> WordCount;
            WordCount=wawc.WordsAndFrequency(words);
            status=wtcf.RedirectToCsvFile(WordCount);
            Console.WriteLine(status);
            //Console.ReadKey();
            
        }
    }
}
