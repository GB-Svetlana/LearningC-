// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] numbers = new int[10];
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(100, 1000);
}
Console.WriteLine(string.Join(", ", numbers));
int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0) count += 1;
}
System.Console.WriteLine($"Количество чётных чисел в массиве: {count}");