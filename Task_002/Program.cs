﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. До 10 символов
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberIndex = Convert.ToString(number);
if (numberIndex.Length > 2)
{
  Console.Write($"The third digit is {numberIndex[2]}");
}
else
{
  Console.Write($"There is NO third digit");
}