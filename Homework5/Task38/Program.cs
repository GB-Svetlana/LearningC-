// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] numbers = new double[10];
FillArrayRandomNumbers(numbers);
Console.WriteLine(string.Join("  ", numbers));
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;
double result = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max) max = numbers[i];
    if (numbers[i] < min)  min = numbers[i];
    result = Math.Round((max - min), 2);
}

Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {result}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(10,1000)) / 10;
        }
}
void PrintArray(double[] numbers)
{
    // Console.Write("[ ");
    // for(int i = 0; i < numbers.Length; i++)
    //     {
    //         Console.Write(numbers[i] + " ");
    //     }
    // Console.Write("]");
    Console.WriteLine();
}