using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo5
{
    class Insect
    {
        private int size;
        private string color;
        
        public Insect(int size, string color)
        {
            this.size = size;   
            this.color = color;
        }
        public void Details()
        {
            Console.WriteLine("Size " + size + " color " + color);
        }
        public void Move()
        {
            Console.WriteLine("Insect Move --->");
        }
        public void Attack()
        {
            Console.WriteLine("Attack --->");
        }
    }
    class Wasp : Insect
    {
        
        public Wasp(int size, string color):base(size,color)
        {
        }
        public void Details()
        {
            Console.WriteLine("The insect details are ");
            base.Details();
        }
        public void Move()
        {
            base.Move();
            Console.WriteLine("Wasp Fly");
        }
        public void Attack()
        {
            base.Attack();
            Console.WriteLine("Wasp Attack");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Wasp w = new Wasp(6,"Green");
            w.Details();
            w.Move();
            w.Attack();
            Console.Read();

        }
    }
}
