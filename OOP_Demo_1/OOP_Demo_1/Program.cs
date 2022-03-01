using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo_1
{
    class Employee
    {
        public int EmpId;
        public String Empname;
        public String address;
        public int age;
        public void GetData()
        {
            Console.WriteLine("Enter Employee ID");
            EmpId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee name");
            Empname = Console.ReadLine();
            Console.WriteLine("Enter Employee Address");
            address = Console.ReadLine();
            Console.WriteLine("Enter Employee Age");
            age = int.Parse(Console.ReadLine());
        }
        public void displayEmpData()
        {
            Console.WriteLine("Employee Id   : " + EmpId);
            Console.WriteLine("Employee Name : "+ Empname);
            Console.WriteLine("Address       : " + address);
            Console.WriteLine("Age           : " + age);
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee();
            obj.GetData();
            obj.displayEmpData();
            Console.Read();
        }
    }
}
