using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileDemo8_WriteInFile_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string loc = "D:\\Demo3";
                FileInfo file = new FileInfo(loc);
                StreamWriter sw = file.CreateText();
                sw.WriteLine("The text is written to the file using Stream Writer Class\nHello Bro\nHie Bro");
                sw.Close();
                StreamReader read = file.OpenText();
                String s= read.ReadToEnd();
                Console.WriteLine(s);
                read.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine("Kichu Akta Bhul Hoeche: " + ex.Message);
            }
            


            Console.ReadLine();



        }

    }
}
