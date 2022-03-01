using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stricture
{
    struct Books
    {
        private string title;
        private string author;
        private string subject;
        private int book_id;
        public void getDetails(string title,string author,string subject,int book_id)
        {
            this.title = title;
            this.author = author;
            this.subject = subject;
            this.book_id = book_id;

        }
        public void Display()
        {
            Console.WriteLine("Title   : " + title);
            Console.WriteLine("Author  : " + author);
            Console.WriteLine("Subject : " + subject);
            Console.WriteLine("Book Id : " + book_id);
        }
    };
    class Program
    {
        static void Main(string[] args)
        {
            Books b1=new Books();
            Books b2 = new Books();
            string t1 = "C programming";
            string a1 = "Bala Goswami";
            string s1 = "C programming tutorial";
            int bo1 = 12342;
            b1.getDetails(t1, a1, s1, bo1);
            //``````````````````````
            string t2 = "Java programming";
            string a2 = "Rakeshwaram Naidu";
            string s2 = "Basic fundamentals of JAVA";
            int bo2 = 12987;
            b2.getDetails(t2, a2, s2, bo2);
            //-----------------------
            Console.WriteLine("Book 1 Details :");
            b1.Display();
            Console.WriteLine();
            Console.WriteLine("Book 2 Details :");
            b2.Display();
            
            Console.Read();
        }
    }
}