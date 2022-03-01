using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileDemo1_WriteByte_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("D:\\Demo.txt", FileMode.OpenOrCreate);
            for (int i = 65; i <= 90; i++)
            {
                fs.WriteByte((byte)i);
            }
            fs.Close();
            Console.Read();
        }
    }
}
