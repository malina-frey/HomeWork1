/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите три числа");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
int SecondNumber = Convert.ToInt32(Console.ReadLine());
int ThirdNumber = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (FirstNumber > SecondNumber)
{
    max = FirstNumber;
}
if (FirstNumber < SecondNumber)
{
    max = SecondNumber;
}
if (ThirdNumber > max)
{
    max = ThirdNumber;
}
Console.WriteLine($"max = {max}");