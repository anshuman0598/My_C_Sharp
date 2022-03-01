using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerDemo3
{

    class IndexedSample
    {
        public static int size;
        private string[] list;
        public IndexedSample(int s)
        {
            size = s;
            list = new string[size];
            for (int i = 0; i < size; i++)
            {
                list[i] = "Unknown";
            }
        }
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < size)
                {
                    return list[index];
                }
                return "";
            }
            set
            {
                if (index >= 0 && index < size)
                {
                    list[index] = value;
                }

            }
        }
    }
    class program
    {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter the number of names space required ");
                int size=int.Parse(Console.ReadLine());

                IndexedSample n = new IndexedSample(size);
                Console.WriteLine("Enter the number of names you want to enter now");
                int j = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the names");
                for(int i = 0; i < j; i++)
                {
                    n[i]= Console.ReadLine();
                }
                Console.WriteLine("-----------------------------------------------------------------");
                Console.WriteLine("The List is");
                Console.WriteLine("-----------------------------------------------------------------");
                for (int i = 0; i < IndexedSample.size; i++)
                {
                    Console.WriteLine("The name of person "+i+" is "+n[i]);
                }
            }
        
    }
}
