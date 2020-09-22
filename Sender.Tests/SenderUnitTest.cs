using System;
using System.IO;
using System.Text;
using Xunit;

namespace Sender.Tests
{
    public class SenderUnitTest
    {
        private readonly string _path= Environment.CurrentDirectory+ @"\Sender_csv\Sender_Csv_File.csv";
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
            string test = "0";
            byte[] byteArray = Encoding.ASCII.GetBytes(test);
            MemoryStream stream = new MemoryStream(byteArray);
            StreamReader reader = new StreamReader(stream);
            //string test = "0";
            //StreamReader input = new StreamReader(test);
           
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
            //string test = "0";
            //StreamReader input = new StreamReader(test);
            ////string text = reader.ReadToEnd();
            // // var input = text ;
            //Console.SetIn(input);
            string test = "0";
            byte[] byteArray = Encoding.ASCII.GetBytes(test);
            MemoryStream stream = new MemoryStream(byteArray);
            StreamReader reader = new StreamReader(stream);
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
