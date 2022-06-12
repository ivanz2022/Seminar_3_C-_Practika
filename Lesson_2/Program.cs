// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

int num = new Random().Next(100, 1000);
Console.WriteLine($"Рандомное число: {num}");
int secondDigit = (num / 10) % 10;
System.Console.WriteLine($"Вторая цифра в этом числе: {secondDigit}");

// Задача 13: Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num < 1000)
{
    int thirdDigit = num % 10;
    Console.WriteLine($"В числе {num} третья цифра {thirdDigit}"); 
}
else if (num > 999 && num < 10000)
{
    int thirdDigit = (num / 10) % 10;
    Console.WriteLine($"В числе {num} третья цифра {thirdDigit}");
}
else if (num > 9999 && num < 100000)
{
    int thirdDigit = (num / 100) % 10;
    Console.WriteLine($"В числе {num} третья цифра {thirdDigit}");
}
else if (num > 100000)
{
    Console.WriteLine("Слишком большое число, введите число поменьше!");
}
else
{
    Console.WriteLine($"В числе {num} нет третьей цифры!");   
}

// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 6 | num == 7)
{
    Console.WriteLine($"День под цифрой {num} является выходным!");
}
else if (num != 0 & num < 6)
{
    Console.WriteLine($"День под цифрой {num} является рабочим!");
}
else 
{
   Console.WriteLine("Неверное число, введите число от 1 до 7: ");   
}

