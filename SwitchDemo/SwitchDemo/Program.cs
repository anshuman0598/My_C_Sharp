using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an Alphabet");
            char choise=char.Parse(Console.ReadLine());
 
            switch (choise)
            {
                case 'a':
                    Console.WriteLine("Vowel");
                    break;
                case 'e':
                    Console.WriteLine("Vowel");
                    break;
                case 'i':
                    Console.WriteLine("Vowel");
                    break;
                case 'o':
                    Console.WriteLine("Vowel");
                    break;
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Consonent");
                    break ;
                    
            }
           /* if(choise==1 )
            {
                Console.WriteLine("1");
            }
            else if(choise==2 )
            {
                Console.WriteLine("2");
            }
            else if(choise ==3 )
            {
                Console.WriteLine("3");
            }
            else if(choise==4)
            {
                Console.WriteLine("4");
            }
            else
            {
                Console.WriteLine("Wrong");
            } */

        }
    }
}
