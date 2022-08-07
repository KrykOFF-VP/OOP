using OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace OOP
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
           while(true)
            {
                Console.WriteLine("Введите любую строчку, для того чтобы зашифровать");
                string encoded = Console.ReadLine()!;
                ACoder Acode = new ACoder();
                Console.WriteLine(Acode.Encode(encoded));

               
                Console.ReadKey(true);


            }
            
        }
    }
}