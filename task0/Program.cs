﻿// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число
// умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Write("Ведите число: ");
int number = int.Parse(Console.ReadLine());
int result = number*number;
Console.WriteLine("Квадрат числа = " + result);