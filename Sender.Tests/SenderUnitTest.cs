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
        string path = @"C:\Users\320087165\Documents\GitHub\review-case-s21b7\Sender_csv\Sender_Csv_File.csv";
        [Fact]
        public void TestFileExistsOrNot()
        {
            bool expectedPath = true;
            bool actualPath = Program.pathOfFile();
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
        // [Fact]
        //public void TestIfGetStringOfWordMethodIsretueningWordorSentence()
        //{

        //    string[] actual = GetSeriesOfWords.ConvertCommentsToWords(path);
        //    Assert.Null(actual);
        //}
        //[Fact]
        //public void TestremovingHeaderIssucessfullOrNot()
        //{
        //    string[] actualWordWithHeader = { "comment", "what" };
        //    string exceptedWordWithoutHeader = GetSeriesOfWords.RemoveHeaderFromWord("what");
        //    Assert.False(actualWordWithHeader[0] == char.ToString(exceptedWordWithoutHeader[0]) && actualWordWithHeader[1] != char.ToString(exceptedWordWithoutHeader[0]));

        //}

    }
}
