﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
if (dayNumber > 7 || dayNumber < 0)
{
    Console.WriteLine($"Не является днем недели");
}
else if (dayNumber == 6 || dayNumber == 7 )
{
    Console.WriteLine($"Это выходной день недели");
}
else
{
        Console.WriteLine($"Это рабочий день недели");
}