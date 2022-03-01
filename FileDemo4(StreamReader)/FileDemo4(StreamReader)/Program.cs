using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileDemo4_StreamReader_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("D:\\Demo.txt", FileMode.OpenOrCreate);
            StreamReader s = new StreamReader(f);
            //String line = s.ReadLine();     //Reads Single Line
            //Console.WriteLine(line);
            string line = "";
            while ((line = s.ReadLine()) != null)   //Reads Multiple Line Untill the end of the document arrives
            {
                Console.WriteLine(line);
            }

            s.Close();
            f.Close();
            Console.Read();
            
        }
    }
}
