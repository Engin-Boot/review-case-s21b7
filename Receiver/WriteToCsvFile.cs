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
        public string RedirectToCsvFile(Dictionary<String, int> wordAndWordFrequency)
        {
            string logstatus;
            try
            {
                using (var writeToCsvFile = new StreamWriter(@"C: \Users\320087165\Documents\GitHub\review -case-s21b7\Receiver_csv\Write.csv"))
                {
                    foreach (KeyValuePair<string, int> wordisKeyWorkFrequencyisValue in wordAndWordFrequency)
                    {
                        writeToCsvFile.WriteLine("{0} , {1}", wordisKeyWorkFrequencyisValue.Key, wordisKeyWorkFrequencyisValue.Value);
                    }
                }
                Console.WriteLine("Writting To File Successfull");
                logstatus = "Writting To File Successfull";
                return logstatus;
            }
            catch(Exception e)
            {
                Console.WriteLine("Error While Writting To File: " + e);
                logstatus = "Error While Writting To File";
                return logstatus;
            }
            
        }
        
    }
}
