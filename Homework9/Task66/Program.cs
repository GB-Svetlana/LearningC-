// Задача 66: Задайте значения M и N. Напишите программу, которая
// найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int GetSum(int min, int max)
{
    if (min == max) return max;
    else return GetSum(min + 1, max) + min;  
}
int n = Prompt("Введите N: ");
int m = Prompt("Введите M: ");
System.Console.Write(GetSum(n, m));