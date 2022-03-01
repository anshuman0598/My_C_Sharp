using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace DeserializationDemo
{
    [Serializable]
    class Student
    {
        public int rollno;
        public string name;
        public Student(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FileStream stream = new FileStream("D:\\SerializationDemo.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            Student s = (Student)formatter.Deserialize(stream);
            Console.WriteLine("Rollno: "+s.rollno);
            Console.WriteLine("Name  : "+s.name);
            stream.Close();
        }
    }
}
