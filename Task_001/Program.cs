// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int firstDigit = number / 100;
int thirdDigit = number % 10;
int result = (number - (firstDigit * 100  + thirdDigit)) / 10;
Console.Write($"Второй цифрой числа является: {result} ");