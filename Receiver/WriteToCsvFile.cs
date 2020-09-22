using System;
using System.Collections.Generic;
using System.IO;


namespace Receiver
{
    public class WriteToCsvFile
    {
        public string RedirectToCsvFile(Dictionary<String, int> wordAndWordFrequency)
        {
            string status;
            try
            {
                using (var writeToCsvFile = new StreamWriter(@"C: \Users\320087165\Documents\GitHub\review -case-s21b7\Receiver_csv\Write.csv"))
                {
                    foreach (KeyValuePair<string, int> wordisKeyWorkFrequencyisValue in wordAndWordFrequency)
                    {
                        writeToCsvFile.WriteLine("{0} , {1}", wordisKeyWorkFrequencyisValue.Key, wordisKeyWorkFrequencyisValue.Value);
                    }
                }
                Console.WriteLine("Writing To File Successful");
                status = "Writing To File Successful";
                return status;
            }
            catch(Exception e)
            {
                Console.WriteLine("Error While Writing To File: " + e);
                status = "Error While Writing To File";
                return status;
            }
            
        }
        
    }
}
