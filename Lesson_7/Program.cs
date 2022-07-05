// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите 1-е число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

double [,] array = new double [num1, num2];

for (int i = 0; i < array.GetLength(0); i++)
{  
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = Convert.ToDouble(new Random().Next(-15, 15)) / 10;
        Console.Write($"{array[i, j]} ");
    } 
Console.WriteLine();
}

// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет (1 индекс строи и 7 индекс столбца).

Console.WriteLine("Введите 1-е число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int[,] array = {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};


if (num1 > array.GetLength(0) - 1 || num2 > array.GetLength(1) - 1)
{
    Console.Write($"Числа {num1}{num2} в массиве нет.");
}
else
{
    Console.Write($"Значение элемента в массиве равно: {array[num1, num2]}.");
}


// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};

for (int j = 0; j < array.GetLength(1); j++)
{  
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {  
        sum += array[i, j];
    } 
    Console.WriteLine($"Среднее арифметическое {j+1} столбца = {sum / array.GetLength(0)}");  
}
    