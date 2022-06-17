// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите 1-е число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число: ");
int numB = Convert.ToInt32(Console.ReadLine());
int i = 1;
int result = numA;

while (i < numB)
{
    result = result * numA;
    i++;  
}
    Console.WriteLine(result); 

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 10)
{
    Console.WriteLine("Число должно быть минимум из двух цифр!");
}
else if (num < 100)
{
    int digit = num / 10 + num % 10;
    Console.WriteLine(digit);
}
else if (num > 100 && num < 1000)
{
    int digit = (num / 100) + (num / 10 % 10) + num % 10;
    Console.WriteLine(digit);
}
else if (num > 1000 && num < 10000)
{
    int digit = (num / 1000) + (num / 100 % 10) + (num / 10 % 10) + num % 10;
    Console.WriteLine(digit);
}
else if (num > 10000 && num < 100000)
{
    int digit = (num / 10000) + (num / 1000 % 10) + (num / 100 % 10) + (num / 10 % 10) + num % 10;
    Console.WriteLine(digit);
}
else
{
    Console.WriteLine("Число слишком большое!");
}

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// Вывод сделать отдельным методом.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void RandomArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,99);
        Console.Write(array[i] + ", ");
    }
}

RandomArray(8);
