using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CreatingDirectoryDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo(@"D:\Directory");
            try
            {
                if (directory.Exists)
                {
                    Console.WriteLine("Directory Already Exist");
                    return;
                }
                directory.Create();
                Console.WriteLine("Directory is Created Successfully");


            }
            catch (Exception ex)
            {
                Console.WriteLine("Directory Not Created: " + ex.ToString());
            }
            Console.Read();

        }
    }
}
