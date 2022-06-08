// Задача 1: Напишите программу, которая на вход принимает
// два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите 1-е число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine(num1 + " больше " + num2);
}
else
{
    Console.WriteLine(num1 + " меньше " + num2);
}


// Задача 2: Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите 1-е число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3-е число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 >= num2 && num1 >= num3)
{
    Console.WriteLine(num1 + " больше чем число " + num2 + " и число " + num3); 
}
else if (num2 >= num1 && num2 >= num3)
{
    Console.WriteLine(num2 + " больше чем число " + num1 + " и число " + num3); 
}
else
{
    Console.WriteLine(num3 + " больше чем число " + num1 + " и число " + num2); 
}


// Задача 3: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("Число " + num + " это чётное число!");
}
else
{
    Console.WriteLine("Число " + num + " это НЕчётное число!");    
} 


// Задача 4: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i <= num)
{
    if (i % 2 == 0)
    {
        Console.Write(i + ", ");
    }  
i++;
}