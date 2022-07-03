using OOP;

account account1 = new account();
account1.number = 12313213;
account1.balance = 500.12m;
account1.type = 5;

Console.WriteLine($"Cчет №:{account1.number} типа:{account1.type}, имеет баланс: {account1.balance}");
Console.WriteLine("Программа завершена");
Console.ReadKey();