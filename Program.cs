//Задача 1
/*Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
int min = a;
int max = a;

if (a < min) min = a;
if (a > max) max = a;
if (b < min) min = b;
if (b > max) max = b;

Console.Write("min = ");
Console.WriteLine(min);
Console.Write("max = ");
Console.WriteLine(max);*/

//Задача 2
/*Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число: ");
int c = int.Parse(Console.ReadLine()!);
int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);*/

//Задача 3
/*Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
if (a % 2 == 0)
{
    Console.Write("Число четное.");    
}
else   
{
    Console.Write("Число нечетное.");
}*/

//Задача 4

Console.WriteLine("Введи число: ");
int a = int.Parse(Console.ReadLine()!);
int b = 1;

while(b <= a)
{
    if (b % 2 == 0)
    Console.Write($"{b} ");
    b++;
}

