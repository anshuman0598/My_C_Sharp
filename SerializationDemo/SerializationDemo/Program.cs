using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace SerializationDemo
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
            //Serialization Code -----------------------------------------------
            FileStream stream1 = new FileStream("D:\\SerializationDemo.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter1 = new BinaryFormatter();
            Student s = new Student(101, "Anshuman");
            formatter1.Serialize(stream1, s);
            stream1.Close();
            //Deserialization Code -----------------------------------------------
            FileStream stream = new FileStream("D:\\SerializationDemo.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            Student s1 = (Student)formatter.Deserialize(stream);
            Console.WriteLine("Rollno: " + s1.rollno);
            Console.WriteLine("Name  : " + s1.name);
            stream.Close();
            
        }
    }
}
