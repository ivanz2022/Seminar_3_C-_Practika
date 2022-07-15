int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

NaturalNumbers(InputInt("Введите число: "));

void NaturalNumbers(int n)
{
    if (n == 0)
        return;
    else
    {
        Console.Write(n + " ");
        NaturalNumbers(n - 1);
    }
}


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = InputInt("Введите m: ");
int n = InputInt("Введите n: ");
int temp = m;

if (m > n)
{
    m = n;
    n = temp;
}

SumNaturalNumbers(m, n, temp = 0);

void SumNaturalNumbers(int m, int n, int summ)
{
    summ = summ + n;
    if (n <= m)
    {
        Console.Write($"Сумма элементов = {summ}");
        return;
    }
    SumNaturalNumbers(m, n - 1, summ);
}


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int m = InputInt("Введите m: ");
int n = InputInt("Введите n: ");

int funcAkkerman = Ack(m, n);

Console.Write($"Функция Аккермана = {funcAkkerman} ");

int Ack(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ack(m - 1, 1);
    else return Ack(m - 1, Ack(m, n - 1));
}
