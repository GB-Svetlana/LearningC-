// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] EnterArray()
{
    System.Console.Write("Введите количество строк массива: ");
    int m = Convert.ToInt32(Console.ReadLine());

    System.Console.Write("Введите количество столбцов массива: ");
    int n = Convert.ToInt32(Console.ReadLine());

    Random random = new Random();
    int[,] Rand = new int[m, n];
    for (int i = 0; i < Rand.GetLength(0); i++)
    {
        for (int j = 0; j < Rand.GetLength(1); j++)
        {
            Rand[i, j] = random.Next(1, 10);
            System.Console.Write($"{Rand[i, j]} ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
    System.Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < Rand.GetLength(1); j++)
    {
        double sum = 0;
        double result = 0;
        for (int i = 0; i < Rand.GetLength(0); i++)
        {
            sum += Rand[i, j];
            result = Math.Round(sum / Rand.GetLength(0), 2);
        }

        Console.Write($"{result}; ");
    }
    return Rand;
}
EnterArray();