using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Sender
{
    public class GetSeriesOfWords
    {

        private readonly List<string> _dateTimeColumn = new List<string>();
      public readonly List<string> CommentColumn = new List<string>();
        
        public static string[] ConvertCommentsToWords(string path)
        {
            GetSeriesOfWords obj = new GetSeriesOfWords();
            ReadingFromCsvFile(path, obj);

            string comment = BuildString(obj);
           string removeHeader = RemoveHeaderFromWord(comment);

            string[] word =removeHeader.Split(' ');
            OutputToConsole.WordsDisplayOnConsole(word);
            ColumFilter.DateTimeCommentsFilter(obj._dateTimeColumn, obj.CommentColumn);
            return word;
        }

        public static string RemoveHeaderFromWord(string removeHeader)
        {
            string wordWithOutHeader = string.Join(" ", removeHeader.Split().Skip(1));
            return wordWithOutHeader;
        }

        public static bool ReadingFromCsvFile(string path, GetSeriesOfWords obj)
        {
            var readingCsvFile = new StreamReader(File.OpenRead(path));

            while (!readingCsvFile.EndOfStream)
            {
                var storeDataEachRowOfCsvFile = readingCsvFile.ReadLine();
                if (storeDataEachRowOfCsvFile != null)
                {
                    var splitColumn = storeDataEachRowOfCsvFile.Split(',', '\n');
                    obj._dateTimeColumn.Add(splitColumn[0]);
                    obj.CommentColumn.Add(splitColumn[1]);
                }
            }
            return true;
        }

        public static string BuildString(GetSeriesOfWords obj)
        {
            StringBuilder builder = new StringBuilder();

            foreach (string commentData in obj.CommentColumn)
            {
                builder.Append(commentData);
            }
            return builder.ToString();
        }
    }
    
}
