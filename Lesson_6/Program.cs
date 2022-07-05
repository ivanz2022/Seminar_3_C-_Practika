// Задача 41: Пользователь вводит с клавиатуры числа через запятую. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа через запятую: ");
string input = Console.ReadLine();
int countNumbers = 1;

for (int i = 0; i < input.Length; i++)
{
    if (input[i] == ',')
    {
        countNumbers++;
    }
}
int[] numbers = new int[countNumbers];
int index = 0;
int countPositiveNumbers = 0;

for (int i = 0; i < input.Length; i++)
{
    string tempString = String.Empty;

    while (input[i] != ',')
    {
        if (i != input.Length - 1)
        {
            tempString += input[i].ToString();
            i++;
        }
        else
        {
            tempString += input[i].ToString();
            break;
        }
    }
    numbers[index] = Convert.ToInt32(tempString);
    index++;
}

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        countPositiveNumbers++;
    }
}

Console.WriteLine($"Чисел больше 0 - {countPositiveNumbers} шт.");


// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

double Input(string output)
{
    Console.Write(output);
    return Convert.ToDouble(Console.ReadLine());
}
double k1 = Input("k1 = ");
double b1 = Input("b1 = ");
double k2 = Input("k2 = ");
double b2 = Input("b2 = ");

if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны");
    return;
}

double x = (b1 - b2) / (k2 - k1);
double y = k1 * x + b1;

Console.WriteLine($"x = {x}, y = {y}");
