// Задача 19: Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number / 10000 == number % 10 && (number / 1000) % 10 == (number / 10) % 10)
{
    Console.WriteLine("Число является палиндромом!");    
}
else
{
    Console.WriteLine("Это число НЕ является палиндромом!");     
}

// Задача 21: Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
Console.Clear();
Console.WriteLine("Введите координаты точки x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

int sumX = x2-x1;
int sumY = y2-y1;
int sumZ = z2-z1;

double distance = Math.Sqrt((sumX*sumX) + (sumY*sumY)+ (sumZ*sumZ));
Console.WriteLine($"Расстояние равно: {distance}");

// Задача 23: Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int i = 0;
while (i < number)
{
    int cube = i * i * i;
    Console.Write($"{cube}, ");
    ++i;
}