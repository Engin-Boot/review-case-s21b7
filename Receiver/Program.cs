using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receiver
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var outputCapture = new OutputCapture())
            {
                //var stuff = outputCapture.Captured.ToString();
                //int val = Convert.ToInt32(stuff);
                string[] words = { "No", "Comments", "Read", "Error", "No", "Comments","No","Comments" };
                Dictionary<String, int> WordCount = new Dictionary<String, int>();
                WordCount=WordAndWordCount.WordsAndFrequency(words);
                WriteToCsvFile.RedirectToCsvFile(WordCount);
                //Console.ReadKey();
            }
        }
        public class OutputCapture : TextWriter, IDisposable
        {
            private TextWriter stdOutWriter;
            public TextWriter Captured { get; private set; }
            public override Encoding Encoding { get { return Encoding.ASCII; } }

            public OutputCapture()
            {
                this.stdOutWriter = Console.Out;
                Console.SetOut(this);
                Captured = new StringWriter();
            }

            override public void Write(string output)
            {

                Captured.Write(output);
                stdOutWriter.Write(output);
            }

            override public void WriteLine(string output)
            {

                Captured.WriteLine(output);
                stdOutWriter.WriteLine(output);
            }


        }
    }
}
