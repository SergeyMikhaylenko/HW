﻿// ЗАДАЧА 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным
// (делится ли оно на два без остатка).

Console.WriteLine("Введите число");
long a = Convert.ToInt64(Console.ReadLine());
if (a % 2 == 0)
{
Console.Write("Чётное число");
}
else
{
Console.Write("Число не чётное");
}