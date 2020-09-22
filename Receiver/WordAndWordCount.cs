using System;
using System.Collections.Generic;

namespace Receiver
{
    public class WordAndWordCount
    {
        public static Dictionary<string,int> WordsAndFrequency(string[] words)
        {
            Dictionary<String, int> wordAndWordFrequency = new Dictionary<String, int>();
            try
            {
                for (int i = 0; i < words.Length; i++)
                {
                    if (wordAndWordFrequency.ContainsKey(words[i]))
                    {
                        wordAndWordFrequency[words[i]] = wordAndWordFrequency[words[i]] + 1;
                    }
                    else
                    {
                        wordAndWordFrequency.Add(words[i], 1);
                    }
                }
                Console.WriteLine("Word Frequency Count Successfull");
            }
            catch(Exception e)
            {
                Console.WriteLine("Word and Word Counting Error: " + e);
            }

            return wordAndWordFrequency;
        }
        
    }
}
