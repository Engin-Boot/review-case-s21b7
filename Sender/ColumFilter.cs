using System;
using System.Collections.Generic;

namespace Sender
{
    public static class ColumFilter
    {
        public static void DateTimeCommentsFilter(List<string> dateTimeColumnData, List<string> comment)
        {
            Console.WriteLine("enter column Number");
            string userColumnInput = Console.ReadLine();
            switch (userColumnInput)
            {
                case "0":
                    ColumnSplit(dateTimeColumnData);
                    break;
                case "1":
                    ColumnSplit(comment);
                    break;
                default:
                    Console.WriteLine("enter Correct Input");
                    break;
            }
        }

        private static void ColumnSplit(List<string> columnData)
        {
            
            string str = columnData.ToString();
            string[] wordSplit = str.Split(' ');
            OutputToConsole.WordsDisplayOnConsole(wordSplit);
        }
    }
}
