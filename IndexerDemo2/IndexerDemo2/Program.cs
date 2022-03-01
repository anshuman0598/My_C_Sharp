using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerOverLoadDemo2
{
    class IndexedNames
    {
        public static int size = 10;
        private string[] namelist = new string[size];
        public IndexedNames()
        {
            for (int i = 0; i < size; i++)
            {
                namelist[i] = "N.A";
            }
        }
        public string this[int index]
        {
            get
            {
                string tmp;
                if (index >= 0 && index < size)
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
                if(index >= 0 && index < size)
                    namelist[index] = value;
            }
        }
        public int this[string name]
        {
            get
            {
                int i = 0;
                while (i < size)
                {
                    if (name == namelist[i])
                    {
                        return i;
                    }
                    i++;
                }
                return i;

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
            for (int i = 0; i < IndexedNames.size; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Index of name Sunil is "+names["Sunil"]);
            Console.ReadLine();
        }
    }
}
