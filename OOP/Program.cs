using OOP;

account account1 = new account();
account1.Setnumber(12313213);
account1.Setbalance(500.12m);
account1.Settype(5);

Console.WriteLine($"Cчет №:{account1.Getnumber()} типа:{account1.Gettype()}, имеет баланс: {account1.Getbalance()}");
Console.WriteLine("Программа завершена");
Console.ReadKey();