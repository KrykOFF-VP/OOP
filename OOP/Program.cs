using OOP;

Account Account1 = new Account(15987.58m, 45);


var Account2 = new Account(4245.42m, 1);

Console.WriteLine($"Cчет №:{Account1.Number} типа:{Account1.Type}, имеет баланс: {Account1.Balance}");
Console.WriteLine($"Cчет №:{Account2.Number} типа:{Account2.Type}, имеет баланс: {Account2.Balance}");
Console.WriteLine("Программа завершена");
Console.ReadKey();