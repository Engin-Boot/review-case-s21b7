using System;
namespace Sender
{
    public static class OutputToConsole
    {

       
        public static string WordsDisplayOnConsole(string[] words)
        {

            foreach (var t in words)
            {
                Console.WriteLine(t);
            }
            //Console.ReadKey();
          string  _log = "Sucessful";
            return _log;

        }
    }
}
