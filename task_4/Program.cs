// ЗАДАЧА 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// (Через тернарный оператор)

Console.WriteLine("Введите первое число");
sbyte a = Convert.ToSByte(Console.ReadLine());
Console.WriteLine("Введите второе число");
sbyte b = Convert.ToSByte(Console.ReadLine());
Console.WriteLine("Введите третье число");
sbyte c = Convert.ToSByte(Console.ReadLine());
sbyte max = b > a ? b : a;
max = max > c ? max : c;

Console.WriteLine("Максимальное число = " +max);