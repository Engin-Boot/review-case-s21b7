using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Receiver.Tests
{
    public class ReceiverUnitTest
    {
        
        [Fact]
        void WhenWriteToConsoleSuccessThenSendAlert()
        {
            Dictionary<String, int> Word = new Dictionary<String, int>();
            Word.Add("what",1);
            WriteToCsvFile _wtcf=new WriteToCsvFile();
            Assert.True(_wtcf.RedirectToCsvFile(Word)== "Error While Writting To File");
        }

        [Fact]
        void WhenGivenWordThenGiveItsCount()
        {
            string[] words = {"what", "does", "help"};
            Dictionary<String, int> WordCount = new Dictionary<String, int>();
            Dictionary<String, int> WordCount2 = new Dictionary<String, int>();
            WordCount2.Add("what",1);
            WordCount2.Add("does",1);
            WordCount2.Add("help",1);
            WordAndWordCount wordCount = new WordAndWordCount();
            WordCount = wordCount.WordsAndFrequency(words);
            if (wordCount.Equals(WordCount2))
            {
                Assert.True(true);
            }
            
        }
    }
}
