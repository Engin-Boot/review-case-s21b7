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
            List<string> CommentColumn = new List<string>();
        public static string[] ConvertCommentsToWords(string path)
        {
            GetSeriesOfWords obj= new GetSeriesOfWords();
            var ReadingCsvFile = new StreamReader(File.OpenRead(@"D:\Review_Csv_File.csv"));
            

            while (!ReadingCsvFile.EndOfStream)
            {
                var StoreDataEachRowOfCsvFile = ReadingCsvFile.ReadLine();
                var SplitColumn = StoreDataEachRowOfCsvFile.Split(',', '\n');
                obj.DateTimeColumn.Add(SplitColumn[0]);
                obj.CommentColumn.Add(SplitColumn[1]);
            }

            StringBuilder builder = new StringBuilder();

            foreach (string CommentData in obj.CommentColumn)
            {
                builder.Append(CommentData);
            }

            string Comment = builder.ToString();
              string RemoveHeader = RemoveHeaderFromWord(Comment);
            
            string[] word = RemoveHeader.Split(' ');
            OutputToConsole.WordsDisplayOnConsole(word);
            return word;
        }

         public static string RemoveHeaderFromWord(string wordWithHeader)
        {
            string wordWithOutHeader = string.Join(" ", wordWithHeader.Split().Skip(1));
            return wordWithOutHeader;

        }
    }
}
