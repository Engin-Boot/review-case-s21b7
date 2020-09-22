using System;
using System.Collections.Generic;

namespace Sender
{
    public class ColumFilter
    {
        public static void DateTimeCommentsFilter(List<string> dateTimeColumnData, List<string> comment)
        {
            // string[] words = ConvertDateTimefromListToString.Split(' ');
            Console.WriteLine("enter column Number");
            string userColumnInput = Console.ReadLine();
            switch (userColumnInput)
            {
                case "0":
                    DateTimeColumn(dateTimeColumnData);
                    break;
                case "1":
                    CommentColumn(comment);
                    break;
                default:
                    Console.WriteLine("enter Correct Input");
                    break;
            }
        }

        public static void DateTimeColumn(List<string> date)
        {
            string str = date.ToString();
            string[] newstr = str.Split(' ');
            OutputToConsole.WordsDisplayOnConsole(newstr);
        }

        public static void CommentColumn(List<string> comment)
        {
            string str = comment.ToString();
            string[] newstr = str.Split(' ');
            OutputToConsole.WordsDisplayOnConsole(newstr);

        }

    }
}
