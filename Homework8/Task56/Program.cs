// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки
// с наименьшей суммой элементов: 1 строка

int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int[,] CreateArray(int m = 7, int n = 5)
{
    int[,] array = new int[m, n + 1];
    return array;
}
void PrintArr(int[,] array)
{
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j],3} ");
        }
        System.Console.WriteLine();
    }
}
int[,] FillArrayRandom(int[,] coll)
{
    for (int i = 1; i < coll.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < coll.GetLength(1) - 1; j++)
        {
            coll[i, j] = new Random().Next(-9, 10);
            sum += coll[i, j];
        }
        coll[i, coll.GetLength(1) - 1] = sum;
    }
    return coll;
}
string FindMinSumNumbersRows(int[,] arr)
{
    int MinRows = arr[0, arr.GetLength(1) - 1];
    int minIndex = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (arr[i, arr.GetLength(1) - 1] < MinRows)
        {
            MinRows = arr[i, arr.GetLength(1) - 1];
            minIndex = i;
        }
    }
    return $"Номер строки с наименьшей суммой элементов: {minIndex}, сумма элементов равна: {MinRows}. ";
}
void Main()
{
    int[,] arr = CreateArray();
    arr = FillArrayRandom(arr);
    PrintArr(arr);
    System.Console.WriteLine();
    System.Console.WriteLine(FindMinSumNumbersRows(arr));
}
Main();
