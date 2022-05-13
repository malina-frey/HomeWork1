/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
Console.WriteLine("Введите два числа");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
int SecondNumber = Convert.ToInt32(Console.ReadLine());
if (FirstNumber > SecondNumber)
{
    Console.WriteLine($"max = {FirstNumber}, min = {SecondNumber}");
}
if (FirstNumber < SecondNumber)
{
    Console.WriteLine($"max = {SecondNumber}, min = {FirstNumber}");
}
if (FirstNumber == SecondNumber)
{
    Console.WriteLine("числа равны");
}