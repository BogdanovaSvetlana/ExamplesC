﻿Console.WriteLine("Введите первое число!");

int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число!");

int b = Convert.ToInt32(Console.ReadLine());

if (b * b == a)
{ 
    Console.WriteLine("Первое число является квадратом второго ");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго ");
}

if (a * a == b)
{ 
    Console.WriteLine("Второе число является квадратом первого ");
}
else
{
    Console.WriteLine("Второе число не является квадратом первого ");
}
