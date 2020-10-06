using System;
using System.IO;
using System.Text;
using Xunit;

namespace Sender.Tests
{
    public class SenderUnitTest
    {
        private readonly string _path= Environment.CurrentDirectory+ @"\Sender_csv\Sender_Csv_File.csv";
        static string test = "0";
        static readonly byte[] ByteArray = Encoding.ASCII.GetBytes(test);
       static readonly MemoryStream  stream = new MemoryStream(ByteArray);
        readonly StreamReader reader = new StreamReader(stream);
        [Fact]
        public void TestFileExistsorNot()
        {
            bool expectedPath = true;
            bool actualPath = CsvFileReader.CheckPathExistOrNot(_path);
            Assert.Equal(expectedPath, actualPath);

            bool expectedPathForFalseReturn = false;
            bool actualPathForFalseReturn= CsvFileReader.CheckPathExistOrNot(_path);
            Assert.NotEqual(expectedPathForFalseReturn, actualPathForFalseReturn);

        }

        
        [Fact]
        public void CheckIfCsv_FileLengthGreaterThenZero()
        {
            string expected = "0";
            string actual = Program.FileLength();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckIfCsvFileIsNull()
        {
            string expected = "1";
            string actual = Program.FileLength();
            Assert.NotEqual(expected, actual);
        }


        [Fact]
        public void TestIfReadingFromCsvIsCorrectForm()
        {
            Assert.True(GetSeriesOfWords.ReadingFromCsvFile(_path, new GetSeriesOfWords()));
        }

        [Fact]
        public void TestGetSeriesOfWords()
        {
           
          
          
           
            Console.SetIn(reader);

            string[] actualWord = GetSeriesOfWords.ConvertCommentsToWords(_path);

            //string[] seriesOfWord = { "what", "does", "this", "help", "with" };
            Assert.Equal("what", actualWord[0]);
            Assert.Equal("does", actualWord[1]);
        }


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
  
        [Fact]
       // [ConsoleInput("0")]
        public void csvFileReader_CheckAndReadCsvFile()
        {
           
            Console.SetIn(reader);

            bool expectedReadTrue = true;
            bool actualReadReturn = CsvFileReader.CheckAndReadCsvFile(_path);
            Assert.Equal(expectedReadTrue, actualReadReturn);

            bool expectedFalseReturn = false;
            bool actualReturn = CsvFileReader.CheckPathExistOrNot(_path);
            Assert.NotEqual(expectedFalseReturn, actualReturn);
        }





        [Fact]
        public void CheckOutputOfConsole()
        {
            string[] word = { "test"};

            Assert.True(OutputToConsole.WordsDisplayOnConsole(word) == "Sucessful");
        }

    }
}
