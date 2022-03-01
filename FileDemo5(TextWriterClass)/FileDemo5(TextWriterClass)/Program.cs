using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileDemo5_TextWriterClass_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (TextWriter writer = File.CreateText("D:\\Demo.txt"))
            {
                writer.WriteLine("Hello C#");
                writer.WriteLine("C# File Handeling");

            };
            Console.WriteLine("Data Written Successfully");
            Console.Read();
        }
    }
}
