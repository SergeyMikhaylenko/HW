// ЗАДАЧА 2: Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число");
byte a = Convert.ToByte(Console.ReadLine());
Console.WriteLine("Введите второе число");
byte b = Convert.ToByte(Console.ReadLine());
if (a > b)
{
Console.Write("Максимальное число "+a);
}
else
{
Console.Write("Максимальное число "+b);
}
