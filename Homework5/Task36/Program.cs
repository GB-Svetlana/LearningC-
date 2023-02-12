// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] numbers = new int[4];
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(-100, 100);
}
Console.WriteLine(string.Join(", ", numbers));
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (i % 2 > 0) sum = sum + numbers[i];
}
System.Console.WriteLine($"Сумма элементов с нечётными индексами в массиве: {sum}");
