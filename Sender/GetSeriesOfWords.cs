using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sender
{
    public class GetSeriesOfWords
    {
       List<string> DateTimeColumn = new List<string>();
      public List<string> CommentColumn = new List<string>();
        
        public static string[] ConvertCommentsToWords(string path)
        {
            GetSeriesOfWords obj = new GetSeriesOfWords();
            bool csvFileread = ReadingFromCsvFile(path, obj);

            string Comment = BuildString(obj);
           string removeHeader = RemoveHeaderFromWord(Comment);

            string[] word =removeHeader.Split(' ');
            OutputToConsole.WordsDisplayOnConsole(word);
            ColumFilter.dateTimeCommentsFilter(obj.DateTimeColumn, obj.CommentColumn);
            return word;
        }

        public static string RemoveHeaderFromWord(string removeHeader)
        {
            string wordWithOutHeader = string.Join(" ", removeHeader.Split().Skip(1));
            return wordWithOutHeader;

        }

        public static bool ReadingFromCsvFile(string path, GetSeriesOfWords obj)
        {
            var ReadingCsvFile = new StreamReader(File.OpenRead(Environment.CurrentDirectory + @"\Sender_csv\Sender_Csv_File.csv"));

            while (!ReadingCsvFile.EndOfStream)
            {
                var StoreDataEachRowOfCsvFile = ReadingCsvFile.ReadLine();
                var SplitColumn = StoreDataEachRowOfCsvFile.Split(',', '\n');
                obj.DateTimeColumn.Add(SplitColumn[0]);
                obj.CommentColumn.Add(SplitColumn[1]);
            }
            return true;
        }

        public static string BuildString(GetSeriesOfWords obj)
        {
            StringBuilder builder = new StringBuilder();

            foreach (string CommentData in obj.CommentColumn)
            {
                builder.Append(CommentData);
            }
            return builder.ToString();
        }
    }
    
}
