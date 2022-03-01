using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileDemo6_TextReaderClass_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (TextReader tr = File.OpenText("D:\\Demo.txt"))
            {
                Console.WriteLine(tr.ReadToEnd());
            }
            Console.Read();
        }
    }
}
