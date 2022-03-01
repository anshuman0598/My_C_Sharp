﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleClassDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var book = new Tuple<string, string, double>("C#.NET", "JOHN", 100.5);
            Console.WriteLine("------------------------------Books Record------------------------------");
            Console.WriteLine("Title " + book.Item1);
            Console.WriteLine("Author " + book.Item2);
            Console.WriteLine("Price " + book.Item3);
            Console.Read();
        }
    }
}
