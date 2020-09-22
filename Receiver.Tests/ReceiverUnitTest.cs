using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Receiver.Tests
{
    public class ReceiverUnitTest
    {
        
        [Fact]
        void WhenWriteToConsoleSuccessThenSendAlert()
        {
            Dictionary<String, int> word = new Dictionary<String, int>();
            word.Add("what",1);
            WriteToCsvFile wtcf=new WriteToCsvFile();
            Assert.True(wtcf.RedirectToCsvFile(word)== "Error While Writting To File");
        }

        [Fact]
        void WhenGivenWordThenGiveItsCount()
        {
            string[] words = {"what", "does", "help"};
            Dictionary<String, int> WordCount;
            Dictionary<String, int> wordCount2 = new Dictionary<String, int>();
            wordCount2.Add("what",1);
            wordCount2.Add("does",1);
            wordCount2.Add("help",1);
            WordAndWordCount wordCount = new WordAndWordCount();
            WordCount = wordCount.WordsAndFrequency(words);
            Assert.Equal(
                WordCount.OrderBy(kv => kv.Key).ToList(),
                wordCount2.OrderBy(kv => kv.Key).ToList()
            );

        }
    }
}
