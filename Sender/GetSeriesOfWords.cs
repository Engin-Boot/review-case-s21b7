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
        public static void ConvertCommentsToWords(string path)
        {
            var ReadingCsvFile = new StreamReader(File.OpenRead(@"D:\Review_Csv_File.csv"));
            List<string> DateTimeColumn = new List<string>();
            List<string> CommentColumn = new List<string>();

            while (!ReadingCsvFile.EndOfStream)
            {
                var StoreDataEachRowOfCsvFile = ReadingCsvFile.ReadLine();
                var SplitColumn = StoreDataEachRowOfCsvFile.Split(',', '\n');
                DateTimeColumn.Add(SplitColumn[0]);
                CommentColumn.Add(SplitColumn[1]);
            }

            StringBuilder builder = new StringBuilder();

            foreach (string CommentData in CommentColumn)
            {
                builder.Append(CommentData);
            }

            string Comment = builder.ToString();
            string[] word = Comment.Split(' ');
            OutputToConsole.WordsDisplayOnConsole(word);
        }
    }
}
