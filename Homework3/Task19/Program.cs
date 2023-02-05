// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int nums = Convert.ToInt32(Console.ReadLine());

if (nums >= 10000)
{
    int division1 = nums / 10000;
    int remainder1 = nums % 10;
    if (division1 == remainder1)
    {
        int nums2 = nums / 10;
        int division2 = (nums2 / 100) % 10;
        int remainder2 = nums2 % 10;
        if (division2 == remainder2)
        {
            Console.Write($"{nums} -> да ");
        }
    }
    else
    {
        Console.WriteLine($"{nums} -> нет ");
    }
}
else
{
    Console.Write("Введено некорректное число: ");
}