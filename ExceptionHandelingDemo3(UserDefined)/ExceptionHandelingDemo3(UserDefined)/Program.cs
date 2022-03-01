using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandelingDemo3_UserDefined_
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message):base(message)
        {

        }
    }
    internal class Program
    {
        static void validate(int age)
        {
            if(age < 18)
            {
                throw new InvalidAgeException("Sorry,Age must be greater than 18");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                validate(12);
            }
            catch(InvalidAgeException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Rest of the Code");
            Console.ReadLine();
        }
    }
}
