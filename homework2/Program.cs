//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел..

Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число");
int c = int.Parse(Console.ReadLine());

if (a > b && a > c) 
{
    Console.WriteLine (a);
}
if (b > a && b > c) 
{
    Console.WriteLine (b);
}
if (c > b && c > a) 
{
    Console.WriteLine (c);
}
if (a > b && c > b)
{
    Console.WriteLine (a);
}
if (b > a && c > a)
{
    Console.WriteLine (b);
}
if (c > b && b < a)
{
    Console.WriteLine (c);
}