using OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


while (true)
{
    Console.WriteLine("Мои задачи");
    Console.WriteLine("=================================");
    Console.WriteLine("1 -> Задание 1");
    Console.WriteLine("2 -> Задание 2");
    Console.WriteLine("3 -> Задание 3");
    Console.WriteLine("0 -> Завершение работы приложения");
    Console.WriteLine("=================================");

    Console.WriteLine("Введите номер задачи: ");
    int number = int.Parse(Console.ReadLine());

    switch (number)                                                                                                 //Создание меню программы
    {
        case 0:
            Console.WriteLine("Завершение работы приложения");
            Console.ReadKey();
            return;

        case 1:
            Task1();
            break;

        case 2:
            Task2();
            break;

        default:
            Console.WriteLine("Укажите значение от 0 до 2");
            break;
    }
}

/// <summary>
/// Решение первого задания
/// </summary>
static void Task1()
{

    Account Akk1 = new Account();
    Akk1.balance = 15987.58m;
    Akk1.type = 45;



    var Akk2 = new Account();
    Akk2.balance = 4245.42m;
    Akk2.type = 1;

    Console.WriteLine($"Cчет №:{Akk1.number} типа:{Akk1.type}, имеет баланс: {Akk1.balance}");
    Console.WriteLine($"Cчет №:{Akk2.number} типа:{Akk2.type}, имеет баланс: {Akk2.balance}");

    Console.WriteLine("Введите сумму для перевода денежных средств");
    decimal money = decimal.Parse(Console.ReadLine());
    Akk1.TransferMoney(ref Akk2, money);

    Console.WriteLine($"Cчет №:{Akk1.number} типа:{Akk1.type}, имеет баланс: {Akk1.balance}");
    Console.WriteLine($"Cчет №:{Akk2.number} типа:{Akk2.type}, имеет баланс: {Akk2.balance}");
    Console.WriteLine("Программа завершена");
    Console.ReadKey();

}

static void Task2()
{

    Console.WriteLine("Введите слово для реверса букв");
    string thisword = Console.ReadLine();
    
   WordReverse reverse = new WordReverse();
    Console.WriteLine(WordReverse.ReverseWord(ref thisword));
  
}