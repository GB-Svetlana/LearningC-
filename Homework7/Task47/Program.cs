﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] EnterArray()
{
    System.Console.WriteLine("Введите количество строк массива: ");
    int m = Convert.ToInt32(Console.ReadLine());

    System.Console.WriteLine("Введите количество столбцов массива: ");
    int n = Convert.ToInt32(Console.ReadLine());

    double[,] Rand = new double[m, n];
    for (int i = 0; i < Rand.GetLength(0); i++)
    {
        for (int j = 0; j < Rand.GetLength(1); j++)
        {
            Rand[i, j] = new Random().Next(-99, 99) / 10.0;
            System.Console.Write($"{Rand [i, j]}  ");
        }
        System.Console.WriteLine();
    }

    return Rand;
}
EnterArray();