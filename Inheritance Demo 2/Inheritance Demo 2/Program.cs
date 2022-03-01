using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Demo_2
{
    class Employee
    {
        public void ShowSalary(int Salary)
        {
            Console.WriteLine("The Salary is : " + Salary);

        }

    }
    // SubClass
    class Bonus : Employee
    {
        public void ShowBonus(int bonus)
        {
            Console.WriteLine("The Bonus is : " + bonus);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bonus obj = new Bonus();
            Console.WriteLine("Enter the Salary: ");
            int s =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Bonus");
            int b = int.Parse(Console.ReadLine());
            obj.ShowSalary(s);
            obj.ShowBonus(b);

        }
    }
}
