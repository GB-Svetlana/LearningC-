// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a == 1)
{
    Console.WriteLine("Понедельник -> нет ");
}
if (a == 2)
{
    Console.WriteLine("Вторник -> нет ");
}
if (a == 3)
{
    Console.WriteLine("Среда -> нет ");
}
if (a == 4)
{
    Console.WriteLine("Четверг -> нет ");
}
if (a == 5)
{
    Console.WriteLine("Пятница -> нет ");
}
if (a == 6)
{
    Console.WriteLine("Суббота -> да ");
}
if (a == 7)
{
    Console.WriteLine("Воскресенье -> да ");
}
if (a > 7)
{
    Console.WriteLine("Введите цифру от 1 до 7: ");
}