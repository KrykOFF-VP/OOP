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

            while (true)
            {
                Console.WriteLine("Выбирите метод шифрования, 1-А , 2-B");
              
                switch (int.Parse(Console.ReadLine())!)
                {
                    case 1:

                        Console.WriteLine("Введите любую строчку, для того чтобы зашифровать ");

                        string encoded = Console.ReadLine();
                        ACoder Acode = new ACoder();
                        Console.WriteLine(Acode.Encode(encoded));
                        Console.ReadKey(true);

                        Console.WriteLine("Введите любую строчку, для того чтобы расшифровать ");
                        string decoded = Console.ReadLine()!;
                        BCoder Bdecode = new BCoder();
                        Console.WriteLine(Bdecode.Decode(decoded));
                        Console.ReadKey(true);
                        break;


                    case 2:


                        Console.WriteLine("Введите любую строчку, для того чтобы зашифровать");

                        string encoded1 = Console.ReadLine();
                        BCoder Bcode = new BCoder();
                        Console.WriteLine(Bcode.Encode(encoded1));
                        Console.ReadKey(true);
                        
                        Console.WriteLine("Введите любую строчку, для того чтобы расшифровать");
                        string decoded1 = Console.ReadLine()!;
                        BCoder Bdecode1 = new BCoder();
                        Console.WriteLine(Bdecode1.Decode(decoded1));
                        Console.ReadKey(true);
                        break;

                    default:
                        Console.WriteLine("Укажите значение  1 или 2");
                        break;

                }
            }
        }
    }
}