// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число степень: ");
int numberB = Convert.ToInt32(Console.ReadLine());
ToDegree(numberA, numberB);


// Функция возведения в степень
void ToDegree(int A, int B)
{
    int result = 1;
    for (int i = 1; i <= B; i++)
    {
        result = result * A;
    }
    Console.WriteLine($"{A}, {B} -> {result}");
}