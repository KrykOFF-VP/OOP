using OOP;

account account1 = new account();
account1.Setbalance(500.12m);
account1.Settype(5);

var account2 = new account();
account2.Setbalance(400.15m);
account2.Settype(1);
Console.WriteLine($"Cчет №:{account1.Getnumber()} типа:{account1.Gettype()}, имеет баланс: {account1.Getbalance()}");
Console.WriteLine($"Cчет №:{account2.Getnumber()} типа:{account2.Gettype()}, имеет баланс: {account2.Getbalance()}");
Console.WriteLine("Программа завершена");
Console.ReadKey();