using System;
using Xunit;

namespace Sender.Tests
{
    public class SenderUnitTest
    {
       string path= Environment.CurrentDirectory+ @"\Sender_csv\Sender_Csv_File.csv";
        [Fact]
        public void TestFileExistsOrNot()
        {
            bool expectedPath = true;
            bool actualPath = Program.PathOfFile();
            Assert.Equal(expectedPath, actualPath);
        }

        [Fact]
        public void CheckIfCsvFileIsEmptyorNot()
        {
            string expected = "0";
            string actual = Program.FileLength();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestIfReadingFromCsvIsCorrectFormorNot()
        {
            Assert.True(GetSeriesOfWords.ReadingFromCsvFile(path, new GetSeriesOfWords()));
        }

      //  [Fact]
        //public void TestGetSeriesOfWordIsSucessfullOrNot()
        //{
        //    string[] actualWord = GetSeriesOfWords.ConvertCommentsToWords(path);

        //    //string[] seriesOfWord = { "what", "does", "this", "help", "with" };
        //    Assert.Equal("what", actualWord[0]);
        //    Assert.Equal("does", actualWord[1]);


        //}
        [Fact]
        public void TestBuildString()
        {
            GetSeriesOfWords obj = new GetSeriesOfWords();
            obj.CommentColumn.Add("Test");
            obj.CommentColumn.Add("Case");
            string expected = "TestCase";
            string actual = GetSeriesOfWords.BuildString(obj);
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void TestremovingHeaderIssucessfullOrNot()
        {
            string actualWordWithHeader = "comment Test Case";
            string actualWordWithoutHeader = GetSeriesOfWords.RemoveHeaderFromWord(actualWordWithHeader);
            string expectedWordWithoutHeader = "Test Case";
            Assert.Equal(actualWordWithoutHeader, expectedWordWithoutHeader);
        }


    }
}
