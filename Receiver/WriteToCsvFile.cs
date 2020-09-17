using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receiver
{
    public class WriteToCsvFile
    {
        public static void RedirectToCsvFile(Dictionary<String, int> wordAndWordFrequency)
        {
            try
            {
                using (var writeToCsvFile = new StreamWriter(@"D:\Write.csv"))
                {
                    foreach (KeyValuePair<string, int> wordisKeyWorkFrequencyisValue in wordAndWordFrequency)
                    {
                        writeToCsvFile.WriteLine("{0} , {1}", wordisKeyWorkFrequencyisValue.Key, wordisKeyWorkFrequencyisValue.Value);
                    }
                }
                Console.WriteLine("Writting To File Successfull");
            }
            catch(Exception e)
            {
                Console.WriteLine("Erro While Writting To File: " + e);
            }
            
        }
        
    }
}
