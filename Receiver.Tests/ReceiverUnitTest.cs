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
    }
}
