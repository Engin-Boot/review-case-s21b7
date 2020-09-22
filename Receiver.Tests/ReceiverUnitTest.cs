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
            Dictionary<String, int> word = new Dictionary<String, int> {{"what", 1}};
            WriteToCsvFile writeToCsv=new WriteToCsvFile();
            Assert.True(writeToCsv.RedirectToCsvFile(word)== "Error While Writing To File");
        }

        [Fact]
        void WhenGivenWordThenGiveItsCount()
        {
            string[] words = {"what", "does", "help"};
            Dictionary<String, int> wordCount2 = new Dictionary<String, int> {{"what", 1}, {"does", 1}, {"help", 1}};
            WordAndWordCount wordCount = new WordAndWordCount();
            var getWordCount = wordCount.WordsAndFrequency(words);
            Assert.Equal(
                getWordCount.OrderBy(kv => kv.Key).ToList(),
                wordCount2.OrderBy(kv => kv.Key).ToList()
            );

        }
    }
}
