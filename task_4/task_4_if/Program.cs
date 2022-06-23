// ЗАДАЧА 4: (Через оператор if)

Console.WriteLine("Введите первое число");
short a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
short b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
short c = Convert.ToInt32(Console.ReadLine());
short max = a;
if (b > a)
max = b;
if (c > max)
max = c;
Console.WriteLine("Максимальное число="+max);

