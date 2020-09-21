using System;
using System.IO;
namespace Sender
{
    public class CsvFileReader
    {
        public static bool CheckAndReadCsvFile(string path)
        {
            bool pathExists = CheckPathExistOrNot(path);
            bool val = false;
            if (pathExists == true)
            {
              string[] getseriesofWords=  GetSeriesOfWords.ConvertCommentsToWords(path);
                val = true;
                return val;
            }
            else
            {
                return val;
            }
        }
        public static bool CheckPathExistOrNot(string path)
        {
            if (File.Exists(path))
            {
                return true;
            }
            else
            {
                Console.WriteLine("File Not Found");
                return false;
            }
        }
    }
}
