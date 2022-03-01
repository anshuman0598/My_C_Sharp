using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileDemo6_BinaryWriterClass_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteBinaryFile();
            ReadBinaryFile();


            Console.WriteLine("Data is written successfully");
            Console.Read();

        }
        static void WriteBinaryFile()
        {
            string fileName = "D:\\Demo2.txt";
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                writer.Write(2.5);
                writer.Write("This is String data");
                writer.Write(true);
                
            }
        }
        static void ReadBinaryFile()
        {

            using (BinaryReader Read = new BinaryReader(File.Open("D:\\Demo2.txt", FileMode.Open)))
            {
                Console.WriteLine("Double Value : " + Read.ReadDouble());
                Console.WriteLine("String Value : " + Read.ReadString());
                Console.WriteLine("Boolean Value: " + Read.ReadBoolean());
            }
        }

        
    }
}
