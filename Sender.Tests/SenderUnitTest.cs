using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Sender.Tests
{
    public class SenderUnitTest
    {
        string path = @"D:\Review_Csv_File.csv";
        [Fact]
        public void TestFileExistsOrNot()
        {
            bool expectedPath = true;
            bool actualPath= Program.pathOfFile();
            Assert.Equal(expectedPath, actualPath);
        }

        
        [Fact]
        public void CheckIfCsvFileIsEmptyorNot()
        {
            string expected = "0";
            string actual = Program.fileLength();
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestIfReadingFromCsvIsCorrectorNot()
        {
          
        }

        [Fact]
        public void TestIfGetStringOfWordMethodIsretueningWordorSentence()
        {

            string[] actual = GetSeriesOfWord.ConvertCommentsToWords(path);
            Assert.Null(actual);
        }
    }
}
