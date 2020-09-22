using System;
using Xunit;

namespace Sender.Tests
{
    public class SenderUnitTest
    {
        private readonly string _path= Environment.CurrentDirectory+ @"\Sender_csv\Sender_Csv_File.csv";
        [Fact]
        public void TestFileExistsOrNot()
        {
            bool expectedPath = true;
            bool actualPath = Program.PathOfFile();
            Assert.Equal(expectedPath, actualPath);
        }

        [Fact]
        public void CheckIfCsvFileIsNull()
        {
            string expected = "0";
            string actual = Program.FileLength();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestIfReadingFromCsvIsCorrectForm()
        {
            Assert.True(GetSeriesOfWords.ReadingFromCsvFile(_path, new GetSeriesOfWords()));
        }

        //[Fact]
        //public void TestGetSeriesOfWords()
        //{
        //    string[] actualWord = GetSeriesOfWords.ConvertCommentsToWords(_path);

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
        public void TestToRemoveHeader()
        {
            string actualWordWithHeader = "comment Test Case";
            string actualWordWithoutHeader = GetSeriesOfWords.RemoveHeaderFromWord(actualWordWithHeader);
            string expectedWordWithoutHeader = "Test Case";
            Assert.Equal(actualWordWithoutHeader, expectedWordWithoutHeader);
        }


    }
}
