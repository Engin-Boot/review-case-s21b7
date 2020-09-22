using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receiver
{
    class Program
    {
        static List<string> inputvalues = new List<string>();
        static void Main(string[] args)
        {
            string s;
            while ((s = Console.ReadLine()) != null)
            {
                //Console.WriteLine(s);
                inputvalues.Add(s);
            }
            //ReadConsoleOutput rd = new ReadConsoleOutput();
            //rd.ParseInputList();
            //foreach(var str in inputvalues)
            //{
            //    Console.WriteLine(str);
            //}

            string[] words = inputvalues.ToArray();

            //foreach (var str in str2)
            //{
            //    Console.WriteLine(str);
            //}
            //string[] words = { "No", "Comments", "Read", "Error", "No", "Comments","No","Comments" };
            WriteToCsvFile _wtcf=new WriteToCsvFile();
            Dictionary<String, int> WordCount = new Dictionary<String, int>();
            WordCount=WordAndWordCount.WordsAndFrequency(words);
            string status=_wtcf.RedirectToCsvFile(WordCount);
            //Console.ReadKey();
            
        }
    }
}
