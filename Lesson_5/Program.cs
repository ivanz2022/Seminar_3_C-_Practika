// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int [3];
int count = 0;

Console.Write("Рандомный массив: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 999);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество четных чисел в массиве, равно {count}.");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int [10];
int sum = 0;

Console.Write("Рандомный массив: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 99);
        Console.Write($"{array[i]} ");
   
    if (i % 2 == 1)
    {
        sum += array[i];
    }
}
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях ровна: {sum}.");


// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементом массива.
// [3 7 22 2 78] -> 76

int[] array = {12, 5, 78, 3, 65, 45};
int max = array[0];
int min = array[0];

Console.Write($"Массив: ");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];   
    }
}
int sum = max - min;
Console.WriteLine();
Console.WriteLine($"Разницу между максимальным и минимальным элементом массива равна: {sum}.");
