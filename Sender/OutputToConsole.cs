using System;
namespace Sender
{
    public class OutputToConsole
    {

       
        public static string WordsDisplayOnConsole(string[] words)
        {
            string _log;
           
            foreach (var t in words)
            {
                Console.WriteLine(t);
            }
            //Console.ReadKey();
            _log = "Sucessful";
            return _log;

        }
    }
}
