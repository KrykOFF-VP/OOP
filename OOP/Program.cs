using OOP;

account account1 = new account();
account1.balance = 15987.58m;
account1.type = 45;

var account2 = new account();
account2.balance = 4245.42m;
account2.type = 1;

Console.WriteLine($"Cчет №:{account1.number} типа:{account1.type}, имеет баланс: {account1.balance}");
Console.WriteLine($"Cчет №:{account2.number} типа:{account2.type}, имеет баланс: {account2.balance}");
Console.WriteLine("Программа завершена");
Console.ReadKey();