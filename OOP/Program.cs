using OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
Account Akk1 = new Account(15987.58m, 45);

var Akk2 = new Account(4245.42m, 1);


Console.WriteLine(Akk1 == Akk2);
Console.WriteLine(Akk1.GetHashCode());
Console.WriteLine(Akk2.GetHashCode());
Console.WriteLine(Akk1.ToString());
Console.WriteLine(Akk2.ToString());

