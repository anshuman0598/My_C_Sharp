using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace DeleteDirectoryDemo
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
                    directory.Delete();
                    Console.WriteLine("Directory Deleted");
                }
                else
                {
                    Console.WriteLine("No Such Directory");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something Went Wrong: " + ex.ToString());
            }
            Console.ReadLine();

        }
    }
}
