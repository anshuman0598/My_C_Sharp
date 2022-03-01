using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask_Transaction_
{
    
    interface Bill
    {
        string GetTransaction();
        string getDate();
        long getAmount();
        void displayDetails();

    }
    class BillImp : Bill
    {
        private int t, d, m, y; 
        private long a;
        public BillImp(int t,int d,int m,int y,long a)
        {
            this.t = t;
            this.d = d;
            this.m = m;
            this.y = y;
            this.a = a;

        }
        public string GetTransaction()
        {
            return ("00" + t);
        }
        public string getDate()
        {
            return (d + "/" + m + "/" + y);
        }
        public long getAmount()
        {
            return a;
        }
        public void displayDetails()
        {
            Console.WriteLine("Transaction: " + GetTransaction());
            Console.WriteLine("Date: " + getDate());
            Console.WriteLine("Amount: " + getAmount());
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BillImp bill = new BillImp(1, 8, 10, 2012, 78900);
            bill.displayDetails();
            BillImp bill2 = new BillImp(2, 9, 10, 2012, 451900);
            bill2.displayDetails();
            Console.Read();
        }
    }
}
