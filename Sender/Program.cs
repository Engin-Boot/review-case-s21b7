using System;
namespace Sender
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:/Review_Csv_File.csv";
            CsvFileReader.CheckAndReadCsvFile(path);
        }
    }
}
