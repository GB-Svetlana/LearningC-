// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int[,,] CreateArray(int m = 2, int n = 2, int l = 2)
{
    int[,,] array = new int[m, n, l];
    return array;
}
int[,,] FillArrayRandom(int[,,] array)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                count = array[i, j, k];
                count++;
                array[i, j, k] = new Random().Next(10, 100);
            }
        }

    }
    return array;
}
void PrintArr(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                System.Console.Write($"{array[i, j, k]} ({j}, {k}, {i}) ");
            }
            System.Console.WriteLine();
        }
    }
}
void Main()
{
    int[,,] arr = CreateArray();
    arr = FillArrayRandom(arr);
    PrintArr(arr);
}
Main();