using System;
using System.Collections.Generic;

namespace Receiver
{
    public class WordAndWordCount
    {
        public Dictionary<string,int> WordsAndFrequency(string[] words)
        {
            Dictionary<String, int> wordAndWordFrequency = new Dictionary<String, int>();
            try
            {
                foreach (var t in words)
                {
                    if (wordAndWordFrequency.ContainsKey(t))
                    {
                        wordAndWordFrequency[t] = wordAndWordFrequency[t] + 1;
                    }
                    else
                    {
                        wordAndWordFrequency.Add(t, 1);
                    }
                }
                Console.WriteLine("Word Frequency Count Successful");
                return wordAndWordFrequency;
            }
            catch(Exception e)
            {
                Console.WriteLine("Word and Word Counting Error: " + e);
            }

            return wordAndWordFrequency;
        }
        
    }
}
