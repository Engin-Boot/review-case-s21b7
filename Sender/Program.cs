using System;
using System.IO;

namespace Sender
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\320087165\Documents\GitHub\review-case-s21b7\Sender_csv\Sender_Csv_File.csv";
            
            CsvFileReader.CheckAndReadCsvFile(path);
        }
        public static string fileLength()
        {

            if (File.ReadAllLines(@"C:\Users\320087165\Documents\GitHub\review-case-s21b7\Sender_csv\Sender_Csv_File.csv").Length > 0)
                return "0";
            else
                return "1";

        }
        public static bool pathOfFile()
        {
            string path = @"C:\Users\320087165\Documents\GitHub\review-case-s21b7\Sender_csv\Sender_Csv_File.csv";

            return File.Exists(path);
        }
    }
}
