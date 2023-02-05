// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координаты точки Ax: ");
double Ax = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки Ay: ");
double Ay = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки Az: ");
double Az = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки Bx: ");
double Bx = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки By: ");
double By = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки Bz: ");
double Bz = Convert.ToInt32(Console.ReadLine());

// Подход: формула для расстояния между двумя точками в 3-х измерениях, т.е. (x1, y1, z1) и (x2, y2, z2) была получена из теоремы Пифагора:
// Расстояние = $ \ sqrt {(x2-x1) ^{2} + (y2-y1) ^{2} + (z2-z1) ^{2}} $ 

double distance = Math.Round(Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2) + Math.Pow(Bz - Az, 2)), 2);
System.Console.WriteLine(distance);