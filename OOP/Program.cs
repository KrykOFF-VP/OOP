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

    Account Akk1 = new Account(15987.58m, 45);
  


    var Akk2 = new Account(4245.42m, 1);
   

    Console.WriteLine($"Cчет №:{Akk1.Number} типа:{Akk1.Type}, имеет баланс: {Akk1.Balance}");
    Console.WriteLine($"Cчет №:{Akk2.Number} типа:{Akk2.Type}, имеет баланс: {Akk2.Balance}");

    Console.WriteLine("Введите сумму для перевода денежных средств");
    decimal money = decimal.Parse(Console.ReadLine());
    Akk1.TransferMoney(ref Akk2, money);

    Console.WriteLine($"Cчет №:{Akk1.Number} типа:{Akk1.Type}, имеет баланс: {Akk1.Balance}");
    Console.WriteLine($"Cчет №:{Akk2.Number} типа:{Akk2.Type}, имеет баланс: {Akk2.Balance}");
    Console.WriteLine("Программа завершена");
    Console.ReadKey();

}

static void Task2()
{

    Console.WriteLine("Введите слово для реверса букв");
    string _thisword = Console.ReadLine();
    
   WordReverse Reverse = new WordReverse();
    Console.WriteLine(WordReverse.ReverseWord(ref _thisword));
  
}