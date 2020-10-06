using System;
using System.IO;
namespace Sender
{
     public static class CsvFileReader
    {
        public static bool CheckAndReadCsvFile(string path)
        {
            bool pathExists = CheckPathExistOrNot(path);
           
            if (pathExists)
            {
                GetSeriesOfWords.ConvertCommentsToWords(path);
                
                return true;
            }
            else
            {
                return false;
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
