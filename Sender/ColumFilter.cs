using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sender
{
    public class ColumFilter
    {
        public static void dateTimeCommentsFilter(List<string> dateTimeColumnData, List<string> Comment)
        {
            string ConvertDateTimefromListToString = dateTimeColumnData.ToString();
            // string[] words = ConvertDateTimefromListToString.Split(' ');
            Console.WriteLine("enter column Number");
            string UserColumnInput = Console.ReadLine();
            switch (UserColumnInput)
            {
                case "0":
                    dateTimeColumn(dateTimeColumnData);
                    break;
                case "1":
                    commentColumn(Comment);
                    break;
                default:
                    Console.WriteLine("enter Correct Input");
                    break;
            }
        }

        public static void dateTimeColumn(List<string> date)
        {
            string str = date.ToString();
            string[] newstr = str.Split(' ');
            OutputToConsole.WordsDisplayOnConsole(newstr);
        }

        public static void commentColumn(List<string> comment)
        {
            string str = comment.ToString();
            string[] newstr = str.Split(' ');
            OutputToConsole.WordsDisplayOnConsole(newstr);

        }

    }
}
