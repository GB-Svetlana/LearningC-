﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

System.Console.WriteLine("Введите координаты точки b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координаты точки k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координаты точки b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координаты точки k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = 0;
double y = 0;

if (k1 == k2)
{
    System.Console.WriteLine("Прямые параллельны");
}
else
{
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    System.Console.WriteLine($"x = {x}, y = {y}");
}