// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= n; i++)
// {
//     System.Console.WriteLine(i * i * i);
// }

Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] MySqare(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = (i + 1) * (i + 1) * (i + 1);
    }
    return numbers;
}

void PrintArr(int[] numbers)
{
    foreach (var item in numbers)
    {
        System.Console.Write(item + " ");
    }
    System.Console.WriteLine("\b\b");
}
// Создаем массив из 0 длины n
int[] arr = new int[n];

// С помощью фкнуции PrintArr выводим получившийся пустой массив
PrintArr(arr);

// С помощью фунции MySqare перезаписываем пустой массив значениями квадратов
arr = MySqare(arr);

// С помощью фкнуции PrintArr выводим массив квадратов
PrintArr(arr);

// простой вариант решения через цикл for
// for (int i = 1; i <= n; i++)
// {
//     System.Console.WriteLine(i*i);
// }