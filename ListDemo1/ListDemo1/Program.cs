using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Messages = new List<string>();
            Messages.Add("Good Morning");
            Messages.Add("Good Afternoon");
            Messages.Add("Good Night");
            Messages.Add("Good Noon");
            Console.WriteLine(Messages.Count+" number of data found in List");
            foreach(string message in Messages)
            {
                Console.WriteLine(message);
            }
            Console.Read();
        }
    }
}
