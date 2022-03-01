using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndxerDemo
{
    class IndexedNames
    {
        public static int size = 10;
        private string[] namelist = new string[size];
        public IndexedNames()
        {
            for(int i=0; i<size; i++)
            {
                namelist[i] = "N.A";
            }
        }
        public string this[int index]
        {
            get
            {
                string tmp;
                if(index>=0 && index < size)
                {
                    tmp = namelist[index];
                }
                else
                {
                    tmp = "";
                }
                return tmp; 
            }
            set
            {
                namelist[index] = value;
            }
        }
        static void Main(string[] args)
        {
            IndexedNames names = new IndexedNames();
            names[0] = "Sam";
            names[1] = "Sita";
            names[2] = "Suresh";
            names[3] = "Shyam";
            names[4] = "Sakshi";
            names[5] = "Sunil";
            names[6] = "Shivam";
            for(int i=0; i<IndexedNames.size; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();
        }
    }
}
